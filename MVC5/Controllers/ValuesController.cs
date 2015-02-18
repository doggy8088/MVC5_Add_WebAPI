using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC5.Controllers
{
    /// <summary>
    /// ASP.NET Web API 範例: Values API 控制器
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// 取得所有 Values
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// 取得單一筆 Value 的值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// 更新一筆新 Value
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// 建立一筆新 Value
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// 刪除一筆新 Value
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}
