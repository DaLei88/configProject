using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace TestConfig
{
    /// <summary>
    /// 单级自定义配置节点
    /// </summary>
    public class CustomerSingleConfig : ConfigurationSection
    {
        /// <summary>
        /// 获取配置信息
        /// </summary>
        /// <returns></returns>
        public static CustomerSingleConfig GetConfig()
        {
            return GetConfig("CustomerSingleConfig");
        }
        /// <summary>
        /// 获取配置信息
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        public static CustomerSingleConfig GetConfig(string sectionName)
        {
            //ConfigurationManager.GetSection()检索当前应用程序默认配置的指定配置部分
            //参数：配置部分的路径和名称。节点名称用正斜杠分隔，例如“ system.net/mailSettings/smtp”
            //result：指定的ConfigurationSection对象，或者null该部分不存在。

            CustomerSingleConfig section = (CustomerSingleConfig)ConfigurationManager.GetSection(sectionName);
            if (section == null)
                throw new ConfigurationErrorsException("Section " + sectionName + " is not found.");
            return section;
        }

        /// <summary>
        /// 平台中文名称
        /// </summary>
        [ConfigurationProperty("PlatChName", DefaultValue = "", IsRequired = true, IsKey = false)]
        public string PlatChName
        {
            get { return (string)this["PlatChName"]; }
            set { this["PlatChName"] = value; }
        }

        /// <summary>
        /// 平台英文名称
        /// </summary>
        [ConfigurationProperty("PlatEnName", DefaultValue = "", IsRequired = true, IsKey = false)]
        public string PlatEnName
        {
            get { return (string)this["PlatEnName"]; }
            set { this["PlatEnName"] = value; }
        }
    }
}
