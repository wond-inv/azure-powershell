// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.WindowsAzure.Commands.Compute.Automation
{
    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object CreateVirtualMachineOSImageCreateDynamicParameters()
        {
            dynamicParameters = new RuntimeDefinedParameterDictionary();
            var pParameters = new RuntimeDefinedParameter();
            pParameters.Name = "VirtualMachineOSImageCreateParameters";
            pParameters.ParameterType = typeof(Microsoft.WindowsAzure.Management.Compute.Models.VirtualMachineOSImageCreateParameters);
            pParameters.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByDynamicParameters",
                Position = 1,
                Mandatory = true
            });
            pParameters.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("VirtualMachineOSImageCreateParameters", pParameters);

            var pArgumentList = new RuntimeDefinedParameter();
            pArgumentList.Name = "ArgumentList";
            pArgumentList.ParameterType = typeof(object[]);
            pArgumentList.Attributes.Add(new ParameterAttribute
            {
                ParameterSetName = "InvokeByStaticParameters",
                Position = 2,
                Mandatory = true
            });
            pArgumentList.Attributes.Add(new AllowNullAttribute());
            dynamicParameters.Add("ArgumentList", pArgumentList);

            return dynamicParameters;
        }

        protected void ExecuteVirtualMachineOSImageCreateMethod(object[] invokeMethodInputParameters)
        {
            VirtualMachineOSImageCreateParameters parameters = (VirtualMachineOSImageCreateParameters)ParseParameter(invokeMethodInputParameters[0]);

            var result = VirtualMachineOSImageClient.Create(parameters);
            WriteObject(result);
        }
    }

    public partial class NewAzureComputeArgumentListCmdlet : ComputeAutomationBaseCmdlet
    {
        protected object[] CreateVirtualMachineOSImageCreateParameters()
        {
            VirtualMachineOSImageCreateParameters parameters = new VirtualMachineOSImageCreateParameters();

            return new object[] { parameters };
        }
    }
}
