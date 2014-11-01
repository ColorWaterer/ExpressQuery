using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HXJ.ExpressQuery.Model
{
    /// <summary>
    /// 快递查询发送单
    /// </summary>
    public class ExpressSend
    {
        /// <summary>
        /// 快递公司代码(英文)(必须)
        /// </summary>
        public string com { get; set; }

        /// <summary>
        /// 快递单号，长度必须大于5位(必须)
        /// </summary>
        public string nu { get; set; }

        /// <summary>
        /// 授权的id(必须)
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 授权KEY(必须)
        /// </summary>
        public string secret { get; set; }

        /// <summary>
        /// 返回结果类型，值分别为 html | json(默认) | text | xml(可选)
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// gbk(默认)| utf8(可选)
        /// </summary>
        public string encode { get; set; }

        /// <summary>
        /// asc(默认)|desc，返回结果排序(可选)
        /// </summary>
        public string ord { get; set; }

        /// <summary>
        /// en返回英文结果，目前仅支持部分快递(EMS、顺丰、DHL)(可选)
        /// </summary>
        public string lang { get; set; }
    }
}
