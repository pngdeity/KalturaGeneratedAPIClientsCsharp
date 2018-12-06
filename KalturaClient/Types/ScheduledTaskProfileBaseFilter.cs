// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2018  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class ScheduledTaskProfileBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string SYSTEM_NAME_EQUAL = "systemNameEqual";
		public const string SYSTEM_NAME_IN = "systemNameIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string LAST_EXECUTION_STARTED_AT_GREATER_THAN_OR_EQUAL = "lastExecutionStartedAtGreaterThanOrEqual";
		public const string LAST_EXECUTION_STARTED_AT_LESS_THAN_OR_EQUAL = "lastExecutionStartedAtLessThanOrEqual";
		public const string LAST_EXECUTION_STARTED_AT_LESS_THAN_OR_EQUAL_OR_NULL = "lastExecutionStartedAtLessThanOrEqualOrNull";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private ScheduledTaskProfileStatus _StatusEqual = (ScheduledTaskProfileStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _LastExecutionStartedAtGreaterThanOrEqual = Int32.MinValue;
		private int _LastExecutionStartedAtLessThanOrEqual = Int32.MinValue;
		private int _LastExecutionStartedAtLessThanOrEqualOrNull = Int32.MinValue;
		#endregion

		#region Properties
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		public ScheduledTaskProfileStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int LastExecutionStartedAtGreaterThanOrEqual
		{
			get { return _LastExecutionStartedAtGreaterThanOrEqual; }
			set 
			{ 
				_LastExecutionStartedAtGreaterThanOrEqual = value;
				OnPropertyChanged("LastExecutionStartedAtGreaterThanOrEqual");
			}
		}
		public int LastExecutionStartedAtLessThanOrEqual
		{
			get { return _LastExecutionStartedAtLessThanOrEqual; }
			set 
			{ 
				_LastExecutionStartedAtLessThanOrEqual = value;
				OnPropertyChanged("LastExecutionStartedAtLessThanOrEqual");
			}
		}
		public int LastExecutionStartedAtLessThanOrEqualOrNull
		{
			get { return _LastExecutionStartedAtLessThanOrEqualOrNull; }
			set 
			{ 
				_LastExecutionStartedAtLessThanOrEqualOrNull = value;
				OnPropertyChanged("LastExecutionStartedAtLessThanOrEqualOrNull");
			}
		}
		#endregion

		#region CTor
		public ScheduledTaskProfileBaseFilter()
		{
		}

		public ScheduledTaskProfileBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerIdIn":
						this._PartnerIdIn = propertyNode.InnerText;
						continue;
					case "systemNameEqual":
						this._SystemNameEqual = propertyNode.InnerText;
						continue;
					case "systemNameIn":
						this._SystemNameIn = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (ScheduledTaskProfileStatus)ParseEnum(typeof(ScheduledTaskProfileStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "lastExecutionStartedAtGreaterThanOrEqual":
						this._LastExecutionStartedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "lastExecutionStartedAtLessThanOrEqual":
						this._LastExecutionStartedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "lastExecutionStartedAtLessThanOrEqualOrNull":
						this._LastExecutionStartedAtLessThanOrEqualOrNull = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public ScheduledTaskProfileBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._IdEqual = data.TryGetValueSafe<int>("idEqual");
			    this._IdIn = data.TryGetValueSafe<string>("idIn");
			    this._PartnerIdEqual = data.TryGetValueSafe<int>("partnerIdEqual");
			    this._PartnerIdIn = data.TryGetValueSafe<string>("partnerIdIn");
			    this._SystemNameEqual = data.TryGetValueSafe<string>("systemNameEqual");
			    this._SystemNameIn = data.TryGetValueSafe<string>("systemNameIn");
			    this._StatusEqual = (ScheduledTaskProfileStatus)ParseEnum(typeof(ScheduledTaskProfileStatus), data.TryGetValueSafe<int>("statusEqual"));
			    this._StatusIn = data.TryGetValueSafe<string>("statusIn");
			    this._CreatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("createdAtGreaterThanOrEqual");
			    this._CreatedAtLessThanOrEqual = data.TryGetValueSafe<int>("createdAtLessThanOrEqual");
			    this._UpdatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("updatedAtGreaterThanOrEqual");
			    this._UpdatedAtLessThanOrEqual = data.TryGetValueSafe<int>("updatedAtLessThanOrEqual");
			    this._LastExecutionStartedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("lastExecutionStartedAtGreaterThanOrEqual");
			    this._LastExecutionStartedAtLessThanOrEqual = data.TryGetValueSafe<int>("lastExecutionStartedAtLessThanOrEqual");
			    this._LastExecutionStartedAtLessThanOrEqualOrNull = data.TryGetValueSafe<int>("lastExecutionStartedAtLessThanOrEqualOrNull");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduledTaskProfileBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("systemNameEqual", this._SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this._SystemNameIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("lastExecutionStartedAtGreaterThanOrEqual", this._LastExecutionStartedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("lastExecutionStartedAtLessThanOrEqual", this._LastExecutionStartedAtLessThanOrEqual);
			kparams.AddIfNotNull("lastExecutionStartedAtLessThanOrEqualOrNull", this._LastExecutionStartedAtLessThanOrEqualOrNull);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case PARTNER_ID_IN:
					return "PartnerIdIn";
				case SYSTEM_NAME_EQUAL:
					return "SystemNameEqual";
				case SYSTEM_NAME_IN:
					return "SystemNameIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case LAST_EXECUTION_STARTED_AT_GREATER_THAN_OR_EQUAL:
					return "LastExecutionStartedAtGreaterThanOrEqual";
				case LAST_EXECUTION_STARTED_AT_LESS_THAN_OR_EQUAL:
					return "LastExecutionStartedAtLessThanOrEqual";
				case LAST_EXECUTION_STARTED_AT_LESS_THAN_OR_EQUAL_OR_NULL:
					return "LastExecutionStartedAtLessThanOrEqualOrNull";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

