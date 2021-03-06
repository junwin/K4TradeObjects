﻿//-----------------------------------------------------------------------
// <copyright file="IExchange.cs" company="KaiTrade LLC">
// Copyright (c) 2013, KaiTrade LLC.
//// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>// <author>John Unwin</author>
// <website>https://github.com/junwin/K2RTD.git</website>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
//using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;

namespace K2DataObjects
{
    [DataContract]
    //[System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Exchange")]
    [JsonObject(MemberSerialization.OptIn)]
    public class Exchange : KaiTrade.Interfaces.IExchange
    {
        private string m_ExchangeCode;
        private string m_Name;

        [DataMember]
        [JsonProperty]
        //[System.Data.Linq.Mapping.ColumnAttribute(Name = "[ExchangeCode]", Storage = "m_ExchangeCode", DbType = "NVarChar(255) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string ExchangeCode
        {
            get
            {
                return m_ExchangeCode;
            }
            set
            {
                m_ExchangeCode = value;
            }
        }

        [DataMember]
        [JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }
    }
}
