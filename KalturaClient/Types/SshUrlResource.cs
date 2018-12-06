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
	public class SshUrlResource : UrlResource
	{
		#region Constants
		public const string PRIVATE_KEY = "privateKey";
		public const string PUBLIC_KEY = "publicKey";
		public const string KEY_PASSPHRASE = "keyPassphrase";
		#endregion

		#region Private Fields
		private string _PrivateKey = null;
		private string _PublicKey = null;
		private string _KeyPassphrase = null;
		#endregion

		#region Properties
		public string PrivateKey
		{
			get { return _PrivateKey; }
			set 
			{ 
				_PrivateKey = value;
				OnPropertyChanged("PrivateKey");
			}
		}
		public string PublicKey
		{
			get { return _PublicKey; }
			set 
			{ 
				_PublicKey = value;
				OnPropertyChanged("PublicKey");
			}
		}
		public string KeyPassphrase
		{
			get { return _KeyPassphrase; }
			set 
			{ 
				_KeyPassphrase = value;
				OnPropertyChanged("KeyPassphrase");
			}
		}
		#endregion

		#region CTor
		public SshUrlResource()
		{
		}

		public SshUrlResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "privateKey":
						this._PrivateKey = propertyNode.InnerText;
						continue;
					case "publicKey":
						this._PublicKey = propertyNode.InnerText;
						continue;
					case "keyPassphrase":
						this._KeyPassphrase = propertyNode.InnerText;
						continue;
				}
			}
		}

		public SshUrlResource(IDictionary<string,object> data) : base(data)
		{
			    this._PrivateKey = data.TryGetValueSafe<string>("privateKey");
			    this._PublicKey = data.TryGetValueSafe<string>("publicKey");
			    this._KeyPassphrase = data.TryGetValueSafe<string>("keyPassphrase");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSshUrlResource");
			kparams.AddIfNotNull("privateKey", this._PrivateKey);
			kparams.AddIfNotNull("publicKey", this._PublicKey);
			kparams.AddIfNotNull("keyPassphrase", this._KeyPassphrase);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PRIVATE_KEY:
					return "PrivateKey";
				case PUBLIC_KEY:
					return "PublicKey";
				case KEY_PASSPHRASE:
					return "KeyPassphrase";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

