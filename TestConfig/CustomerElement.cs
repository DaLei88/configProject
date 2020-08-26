using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace TestConfig
{
    /// <summary>
    /// 多级节点 ConfigurationElement（配置元素）
    /// </summary>
    public class CustomerElement : ConfigurationElement
    {
        private const string EnablePropertyName = "enabled";

        private const string ConnectionStringPropery = "connectionString";

        [ConfigurationProperty(EnablePropertyName, IsRequired = true)]
        public bool Enabled
        {
            get { return (bool)base[EnablePropertyName]; }
            set { base[EnablePropertyName] = value; }
        }

        [ConfigurationProperty(ConnectionStringPropery, IsRequired = true)]
        public string ConnectionString
        {
            get { return (string)base[ConnectionStringPropery]; }
            set { base[ConnectionStringPropery] = value; }
        }
    }
}
