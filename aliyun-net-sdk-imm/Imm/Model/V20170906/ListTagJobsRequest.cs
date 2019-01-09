/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class ListTagJobsRequest : RpcAcsRequest<ListTagJobsResponse>
    {
        public ListTagJobsRequest()
            : base("imm", "2017-09-06", "ListTagJobs", "2017-09-06", "openAPI")
        {
        }

		private string condition;

		private int? maxKeys;

		private string marker;

		private string action;

		private string project;

		private string accessKeyId;

		public string Condition
		{
			get
			{
				return condition;
			}
			set	
			{
				condition = value;
				DictionaryUtil.Add(QueryParameters, "Condition", value);
			}
		}

		public int? MaxKeys
		{
			get
			{
				return maxKeys;
			}
			set	
			{
				maxKeys = value;
				DictionaryUtil.Add(QueryParameters, "MaxKeys", value.ToString());
			}
		}

		public string Marker
		{
			get
			{
				return marker;
			}
			set	
			{
				marker = value;
				DictionaryUtil.Add(QueryParameters, "Marker", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListTagJobsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListTagJobsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}