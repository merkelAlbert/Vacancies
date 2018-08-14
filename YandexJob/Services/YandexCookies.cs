using System;
using System.Net;

namespace YandexJob.Services
{
    public class YandexCookies
    {
        public CookieContainer Cookies { get; set; }

        public YandexCookies(string url)
        {
            Cookies = new CookieContainer();
            Cookies.Add(new Uri(url), new Cookie("yandexuid", "3409407111513863908"));
            Cookies.Add(new Uri(url),
                new Cookie("yp",
                    "1829223908.yrts.1513863908#1561640063.p_sw.1530104063#1536787843.shlos.0#1534790335.szm.1%3A1366x768%3A1366x630#1534271935.ln_tp.01#1849556631.multib.1"));
            Cookies.Add(new Uri(url),
                new Cookie("i",
                    "THs9aXjq1h0dh7Pmmvc2qcCxa2550SduPxxZktdVDXoVqpSllzY8VIwqf6g4g2gkIukxaytvzgcTNersEmsHxeVoM4Y="));
            Cookies.Add(new Uri(url), new Cookie("mda", "0"));
            Cookies.Add(new Uri(url), new Cookie("_ym_uid", "1526849198449985406"));
            Cookies.Add(new Uri(url),
                new Cookie("fuid01",
                    "5b01deb05a03589a.0sEJipH-peEhI0jD0fuwbq19PP1tkQIUMRqIL6nUFVc0MdUtSho_xUlPXGeVLoFkhSD0cxR2DFVIUDwTsFoKLcfPhgLClBwuQkHQKw9VqRA0Ap6Z2Z73VERao7tz3wIQ"));
            Cookies.Add(new Uri(url), new Cookie("_ym_d", "1530103859"));
            Cookies.Add(new Uri(url),
                new Cookie("fuid01",
                    "5b01deb05a03589a.0sEJipH-peEhI0jD0fuwbq19PP1tkQIUMRqIL6nUFVc0MdUtSho_xUlPXGeVLoFkhSD0cxR2DFVIUDwTsFoKLcfPhgLClBwuQkHQKw9VqRA0Ap6Z2Z73VERao7tz3wIQ"));
            Cookies.Add(new Uri(url), new Cookie("from_lifetime", "1534196634211"));
            Cookies.Add(new Uri(url), new Cookie("from", "direct"));
            Cookies.Add(new Uri(url), new Cookie("rheftjdd", "rheftjddVal"));
            Cookies.Add(new Uri(url),
                new Cookie("_ym_wasSynced",
                    "%7B%22time%22%3A1534185534880%2C%22params%22%3A%7B%22webvisor%22%3A%7B%22date%22%3A%222011-10-31%2016%3A20%3A50%22%7D%2C%22eu%22%3A0%7D%2C%22bkParams%22%3A%7B%7D%7D"));
            Cookies.Add(new Uri(url), new Cookie("ym_isad", "2"));
            Cookies.Add(new Uri(url), new Cookie("ys", "wprid.1534195600705653-1090547089419914657673956-man1-3514"));
            Cookies.Add(new Uri(url),
                new Cookie("L",
                    "alNgeFp7RmQLClNjXnRPXQBvRHQOe2RLDy8xXH4+Sn8oYGJT.1534186397.13590.330536.b6a3483929b1becbede92b366a899183"));
            Cookies.Add(new Uri(url), new Cookie("X-Vertis-DC", "sas"));
            Cookies.Add(new Uri(url), new Cookie("_ym_visorc_1276757", "w"));
        }

        
        
        
    }
}