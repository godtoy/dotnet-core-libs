﻿using MongoDB.Bson;
using Newtonsoft.Json;

namespace bx_core.Model
{
    public class BxUser
    {
        public ObjectId _id { get; set; }

        public string accId { get; set; }

        // <summary>
        /// 
        /// </summary>
        public string userId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string yppNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string avatar { get; set; }

        private string _nickname = "";

        /// <summary>
        /// yj哥哥哥哥哥哥哥哥
        /// </summary>
        public string nickname
        {
            get => _nickname;
            set => _nickname = value.Replace("_", "");
        }

        /// <summary>
        /// 
        /// </summary>
        public string sign { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string diamondVipLevel { get; set; }

        /// <summary>
        /// 骑士0
        /// </summary>
        public string diamondVipName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string isFollow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string birthday { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string headImgUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string relational { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int voiceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string scheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string timeHint { get; set; }

        public long fansCount { get; set; }
        public string showNo { get; set; }
        public bool isAuth { get; set; }
        public bool isGod { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}