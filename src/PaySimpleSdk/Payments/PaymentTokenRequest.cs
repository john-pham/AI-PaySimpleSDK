﻿using System;
using System.Collections.Generic;
using System.Linq;
#region License
// The MIT License (MIT)
//
// Copyright (c) 2015 Scott Lance
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// The most recent version of this license can be found at: http://opensource.org/licenses/MIT
#endregion

using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PaySimpleSdk.Accounts;
using PaySimpleSdk.Exceptions;
using PaySimpleSdk.Payments.Validation;
using PaySimpleSdk.Validation;

namespace PaySimpleSdk.Payments
{
	/// <summary>
	/// Used to retrieve a token that will represent the protected card data
	/// </summary>
	public class PaymentTokenRequest : ProtectedCardData, IValidatable
	{
		[JsonProperty]
		public int CustomerAccountId { get; set; }

		[JsonProperty]
		public int CustomerId { get; set; }

		[JsonProperty]
		public bool IsNewlyCreated { get; set; }

		public IEnumerable<ValidationError> Validate()
		{
			return Validator.Validate<PaymentTokenRequest, PaymentTokenRequestValidator>(this);
		}
	}
}
