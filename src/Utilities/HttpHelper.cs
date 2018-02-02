﻿/*
 * Created by SharpDevelop.
 * User: RedXu
 * Date: 2015-04-16
 * Time: 13:58
 * todo 先用着, 想自己写完善的http是比较麻烦的, 保留原作者的头描述
 * https://raw.githubusercontent.com/redxu/HttpHelper/master/HttpHelper.cs
 * 作者 github 地址 : https://github.com/redxu/HttpHelper
 */
using System;
using System.Net;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Net.Security;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Utilities
{
    /// <summary>
    /// Http操作类.
    /// </summary>
    public class HttpHelper
    {
        private const int ConnectionLimit = 100;
        //编码
        private Encoding _encoding = Encoding.Default;
        //浏览器类型
        private readonly string[] _useragents = {
            "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.90 Safari/537.36",
            "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/7.0; SLCC2; .NET CLR 2.0.50727; .NET CLR 3.5.30729; .NET CLR 3.0.30729; Media Center PC 6.0)",
            "Mozilla/5.0 (Windows NT 6.1; rv:36.0) Gecko/20100101 Firefox/36.0",
            "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:31.0) Gecko/20130401 Firefox/31.0"
        };
        //接受类型
        private string _accept = "text/html, application/xhtml+xml, application/xml, */*";
        //超时时间
        private int _timeout = 30 * 1000;
        //类型
        private string _contenttype = "application/x-www-form-urlencoded";
        //cookies
        public string Cookies { get; private set; } = string.Empty;
        //cookies
        private CookieCollection _cookiecollection;
        //custom heads
        private readonly Dictionary<string, string> _headers = new Dictionary<string, string>();

        public string Useragent { get => Useragent1; set => Useragent1 = value; }
        public string Useragent1 { get; set; } = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.90 Safari/537.36";

        public HttpHelper()
        {
            _headers.Clear();
            //随机一个useragent
            Useragent = _useragents[new Random().Next(0, _useragents.Length)];
            //解决性能问题?
            ServicePointManager.DefaultConnectionLimit = ConnectionLimit;
        }

        public void InitCookie()
        {
            Cookies = "";
            _cookiecollection = null;
            _headers.Clear();
        }

        /// <summary>
        /// 设置当前编码
        /// </summary>
        /// <param name="en"></param>
        public void SetEncoding(Encoding en)
        {
            _encoding = en;
        }

        /// <summary>
        /// 设置UserAgent
        /// </summary>
        /// <param name="ua"></param>
        public void SetUserAgent(string ua)
        {
            Useragent = ua;
        }

        public void RandUserAgent()
        {
            Useragent = _useragents[new Random().Next(0, _useragents.Length)];
        }

        public void SetCookiesString(string c)
        {
            Cookies = c;
        }

        /// <summary>
        /// 设置超时时间
        /// </summary>
        public void SetTimeOut(int msec)
        {
            _timeout = msec;
        }

        public void SetContentType(string type)
        {
            _contenttype = type;
        }

        public void SetAccept(string accept)
        {
            _accept = accept;
        }

        /// <summary>
        /// 添加自定义头
        /// </summary>
        /// <param name="key"></param>
        /// <param name="ctx"></param>
        public void AddHeader(string key, string ctx)
        {
            //_headers.Add(key,ctx);
            _headers[key] = ctx;
        }

        /// <summary>
        /// 清空自定义头
        /// </summary>
        public void ClearHeader()
        {
            _headers.Clear();
        }

        /// <summary>
        /// 获取HTTP返回的内容
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private string GetStringFromResponse(HttpWebResponse response)
        {
            if (response == null)
            {
                throw new ArgumentNullException(nameof(response));
            }

            var html = string.Empty;
            try
            {
                var stream = response.GetResponseStream();
                var sr = new StreamReader(stream ?? throw new InvalidOperationException(), _encoding);
                html = sr.ReadToEnd();
                sr.Close();
                stream.Close();
            }
            catch (Exception e)
            {
                Trace.WriteLine("GetStringFromResponse Error: " + e.Message);
            }

            return html;
        }

        /// <summary>
        /// 检测证书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        private static bool CheckCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        /// <summary>
        /// 发送GET请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string HttpGet(string url)
        {
            return HttpGet(url, url);
        }

        /// <summary>
        /// 发送GET请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="refer"></param>
        /// <returns></returns>
        public string HttpGet(string url, string refer)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = CheckCertificate;
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = Useragent;
                request.Timeout = _timeout;
                request.ContentType = _contenttype;
                request.Accept = _accept;
                request.Method = "GET";
                request.Referer = refer;
                request.KeepAlive = true;
                request.AllowAutoRedirect = true;
                request.UnsafeAuthenticatedConnectionSharing = true;
                request.CookieContainer = new CookieContainer();
                //据说能提高性能
                // ReSharper disable once AssignNullToNotNullAttribute
                request.Proxy = null;
                if (_cookiecollection != null)
                {
                    foreach (Cookie c in _cookiecollection)
                    {
                        c.Domain = request.Host;
                    }

                    request.CookieContainer.Add(_cookiecollection);
                }

                foreach (var hd in _headers)
                {
                    request.Headers[hd.Key] = hd.Value;
                }

                var response = (HttpWebResponse)request.GetResponse();
                var html = GetStringFromResponse(response);
                if (request.CookieContainer != null)
                {
                    response.Cookies = request.CookieContainer.GetCookies(request.RequestUri);
                }

                if (response.Cookies != null)
                {
                    _cookiecollection = response.Cookies;
                }
                if (response.Headers["Set-Cookie"] != null)
                {
                    var tmpcookie = response.Headers["Set-Cookie"];
                    _cookiecollection.Add(ConvertCookieString(tmpcookie));
                }

                response.Close();
                return html;
            }
            catch (Exception e)
            {
                Trace.WriteLine("HttpGet Error: " + e.Message);
                return string.Empty;
            }
        }

        /// <summary>
        /// 获取MINE文件
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public byte[] HttpGetMine(string url)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = CheckCertificate;
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = Useragent;
                request.Timeout = _timeout;
                request.ContentType = _contenttype;
                request.Accept = _accept;
                request.Method = "GET";
                request.Referer = url;
                request.KeepAlive = true;
                request.AllowAutoRedirect = true;
                request.UnsafeAuthenticatedConnectionSharing = true;
                request.CookieContainer = new CookieContainer();
                //据说能提高性能
                // ReSharper disable once AssignNullToNotNullAttribute
                request.Proxy = null;
                if (_cookiecollection != null)
                {
                    foreach (Cookie c in _cookiecollection)
                        c.Domain = request.Host;
                    request.CookieContainer.Add(_cookiecollection);
                }

                foreach (KeyValuePair<string, string> hd in _headers)
                    request.Headers[hd.Key] = hd.Value;

                var response = (HttpWebResponse)request.GetResponse();
                var stream = response.GetResponseStream();
                var ms = new MemoryStream();

                var b = new byte[1024];
                while (true)
                {
                    if (stream != null)
                    {
                        var s = stream.Read(b, 0, b.Length);
                        ms.Write(b, 0, s);
                        if (s == 0 || s < b.Length)
                        {
                            break;
                        }
                    }
                }
                var mine = ms.ToArray();
                ms.Close();

                if (request.CookieContainer != null)
                {
                    response.Cookies = request.CookieContainer.GetCookies(request.RequestUri);
                }

                if (response.Cookies != null)
                {
                    _cookiecollection = response.Cookies;
                }
                if (response.Headers["Set-Cookie"] != null)
                {
                    Cookies = response.Headers["Set-Cookie"];
                }

                stream.Close();
                stream.Dispose();
                response.Close();
                return mine;
            }
            catch (Exception e)
            {
                Trace.WriteLine("HttpGetMine Error: " + e.Message);
                return null;
            }
        }

        /// <summary>
        /// 发送POST请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public string HttpPost(string url, string data)
        {
            return HttpPost(url, data, url);
        }

        /// <summary>
        /// 发送POST请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <param name="refer"></param>
        /// <returns></returns>
        public string HttpPost(string url, string data, string refer)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = CheckCertificate;
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = Useragent;
                request.Timeout = _timeout;
                request.Referer = refer;
                request.ContentType = _contenttype;
                request.Accept = _accept;
                request.Method = "POST";
                request.KeepAlive = true;
                request.AllowAutoRedirect = true;
                request.CookieContainer = new CookieContainer();
                //据说能提高性能
                // ReSharper disable once AssignNullToNotNullAttribute
                request.Proxy = null;

                if (_cookiecollection != null)
                {
                    foreach (Cookie c in _cookiecollection)
                    {
                        c.Domain = request.Host;
                        if (c.Domain.IndexOf(':') > 0)
                            c.Domain = c.Domain.Remove(c.Domain.IndexOf(':'));
                    }
                    request.CookieContainer.Add(_cookiecollection);
                }

                foreach (var hd in _headers)
                {
                    request.Headers[hd.Key] = hd.Value;
                }
                var buffer = _encoding.GetBytes(data.Trim());
                request.ContentLength = buffer.Length;
                request.GetRequestStream().Write(buffer, 0, buffer.Length);
                request.GetRequestStream().Close();

                var response = (HttpWebResponse)request.GetResponse();
                var html = GetStringFromResponse(response);
                if (request.CookieContainer != null)
                {
                    response.Cookies = request.CookieContainer.GetCookies(request.RequestUri);
                }
                if (response.Cookies != null)
                {
                    _cookiecollection = response.Cookies;
                }
                if (response.Headers["Set-Cookie"] != null)
                {
                    var tmpcookie = response.Headers["Set-Cookie"];
                    _cookiecollection.Add(ConvertCookieString(tmpcookie));
                }

                response.Close();
                return html;
            }
            catch (Exception e)
            {
                Trace.WriteLine("HttpPost Error: " + e.Message);
                return string.Empty;
            }
        }

        public string UrlEncode(string str)
        {
            var sb = new StringBuilder();
            var byStr = _encoding.GetBytes(str);
            foreach (var b in byStr)
            {
                sb.Append(@"%" + Convert.ToString(b, 16));
            }

            return (sb.ToString());
        }

        /// <summary>
        /// 转换cookie字符串到CookieCollection
        /// </summary>
        /// <param name="ck"></param>
        /// <returns></returns>
        private CookieCollection ConvertCookieString(string ck)
        {
            var cc = new CookieCollection();
            var cookiesarray = ck.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var cookie in cookiesarray)
            {
                var cookiesarray2 = cookie.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                foreach (var cookie2 in cookiesarray2)
                {
                    var cookiesarray3 = cookie2.Trim().Split("=".ToCharArray());
                    if (cookiesarray3.Length == 2)
                    {
                        var cname = cookiesarray3[0].Trim();
                        var cvalue = cookiesarray3[1].Trim();
                        if (cname.ToLower() != "domain" && cname.ToLower() != "path" && cname.ToLower() != "expires")
                        {
                            var c = new Cookie(cname, cvalue);
                            cc.Add(c);
                        }
                    }
                }
            }
            return cc;
        }

         public void DebugCookies()
        {
            Trace.WriteLine("**********************BEGIN COOKIES*************************");
            foreach (Cookie c in _cookiecollection)
            {
                Trace.WriteLine(c.Name + "=" + c.Value);
                Trace.WriteLine("Path=" + c.Path);
                Trace.WriteLine("Domain=" + c.Domain);
            }
            Trace.WriteLine("**********************END COOKIES*************************");
        }
    }
}