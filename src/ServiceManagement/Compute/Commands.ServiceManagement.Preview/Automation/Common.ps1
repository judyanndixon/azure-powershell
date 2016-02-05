# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

$VerbosePreference='Continue';
$ErrorActionPreference = "Stop";

$NEW_LINE = "`r`n";
$BAR_LINE = "=============================================";
$SEC_LINE = "---------------------------------------------";
$verbs_common_new = "VerbsCommon.New";
$verbs_lifecycle_invoke = "VerbsLifecycle.Invoke";

$common_verb_mapping =
@{
"CreateOrUpdate" = "New";
"Get" = "Get";
"List" = "Get";
"Delete" = "Remove";
"Deallocate" = "Stop";
"PowerOff" = "Stop";
"Start" = "Start";
"Restart" = "Restart";
"Capture" = "Save";
"Update" = "Update";
};

$common_noun_mapping =
@{
"VirtualMachine" = "VM";
"ScaleSet" = "SS";
};

$code_common_usings = @(
    'System',
    'System.Collections.Generic',
    'System.Linq',
    'System.Management.Automation',
    'Microsoft.Azure'
);

$code_common_header =
@"
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
"@;