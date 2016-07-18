﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Com.Netease.Is.Antispam.Demo
{
    class TextCheckApiDemo
    {
        public static void textCheck()
        {
            /** 产品密钥ID，产品标识 */
            String secretId = "your_secret_id";
            /** 产品私有密钥，服务端生成签名信息使用，请严格保管，避免泄露 */
            String secretKey = "your_secret_key";
            /** 业务ID，易盾根据产品业务特点分配 */
            String businessId = "your_business_id";
            /** 易盾反垃圾云服务文本在线检测接口地址 */
            String apiUrl = "https://api.aq.163.com/v2/text/check";
            Dictionary<String, String> parameters = new Dictionary<String, String>();

            long curr = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
            String time = curr.ToString();

            // 1.设置公共参数
            parameters.Add("secretId", secretId);
            parameters.Add("businessId", businessId);
            parameters.Add("version", "v2");
            parameters.Add("timestamp", time);
            parameters.Add("nonce", new Random().Next().ToString());

            // 2.设置私有参数
            parameters.Add("dataId", "ebfcad1c-dba1-490c-b4de-e784c2691768");
            parameters.Add("content", "易盾测试内容！");
            parameters.Add("dataOpType", "1");
            parameters.Add("ip", "123.115.77.137");
            parameters.Add("dataType", "1");
            parameters.Add("parentDataId", "334d42e1-112f-4fc7-8fb7-c60542fc2018");
            parameters.Add("title", "易盾测试标题");
            parameters.Add("url", "http://www.xx.com/xxx.html");
            parameters.Add("account", "csharp@163.com");
            parameters.Add("nickname", "没事瞎评论csharp");
            parameters.Add("deviceType", "4");
            parameters.Add("deviceId", "92B1E5AA-4C3D-4565-A8C2-86E297055088");
            parameters.Add("callback", "ebfcad1c-dba1-490c-b4de-e784c2691768");
            parameters.Add("publishTime", time);

            // 3.生成签名信息
            String signature = Utils.genSignature(secretKey, parameters);
            parameters.Add("signature", signature);

            // 4.发送HTTP请求
            HttpClient client = Utils.makeHttpClient();
            String result = Utils.doPost(client, apiUrl, parameters, 1000);
            if(result != null)
            {
                JObject ret = JObject.Parse(result);
                int code = ret.GetValue("code").ToObject<Int32>();
                String msg = ret.GetValue("msg").ToObject<String>();
                if (code == 200)
                {
                    JObject resultObject = (JObject)ret["result"];
                    int action = resultObject["action"].ToObject<Int32>();
                    if (action == 1)
                    {
			             Console.WriteLine("正常内容，通过");
                    }
                    else if (action == 2)
                    {
			             Console.WriteLine("垃圾内容，删除");
                    }
                    else if (action == 3)
                    {
			             Console.WriteLine("嫌疑内容");
                    }
                }
                else
                {
                    Console.WriteLine(String.Format("ERROR: code={0}, msg={1}", code, msg));
                }
            }
            else
            {
                Console.WriteLine("Request failed!");
            }

        }      
    }
}
