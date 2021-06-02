# TiliaLabs.Phoenix - The C# tilia Phoenix client library

The `TiliaLabs.Phoenix` C# client provides drop-in connectivity between .NET environments and the award winning tilia Phoenix with entities and methods covering every corner of the extensive tilia Phoenix REST API. 

The code is mostly generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project using the tilia Phoenix Open API specification, with additional fixes, enhancements, and unit tests added by the Tilia Labs development team.

tilia Phoenix and the tilia Phoenix C# client are both developed by [Tilia Labs](https://tilialabs.com).

<a name="api-version"></a>
## API version
- tilia Phoenix 7.0 or later

<a name="frameworks-supported"></a>
## Prerequisites
- .NET 4.0 or later or Windows Phone 7.1 (Mango) or later
- A licensed copy of tilia Phoenix 7.0 or later with the Automate module

## Open source

This application and all code herein is open sourced under the Apache 2.0 license.  You are free to customize this code and use your modifications for commercial purposes with or without publishing your changes.

Tilia Labs is the sole maintainer of this repository, but we encourage suggestions and pull requests to help make this client better than ever for our global graphic arts community!

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using TiliaLabs.Phoenix.Api;
using TiliaLabs.Phoenix.Client;
using TiliaLabs.Phoenix.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using TiliaLabs.Phoenix.Api;
using TiliaLabs.Phoenix.Client;
using TiliaLabs.Phoenix.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            Configuration config = Configuration.Default;
            config.BasePath = "http://localhost:8022/phoenix";
            var instance = new ProjectsAPIApi(config);
            
            // Create new Phoenix project
            var body = new CreateJobResource(id: "123");
            ResponseEntity response = instance.CreateJob(body);
            Assert.IsTrue(response.Success.Value);
            
            // Add new flat product to the project
            AddProductEntity product1 = new AddProductEntity(name: "Product 1",
                type: AddProductEntity.TypeEnum.Flat,  ordered: 50000,
                width: "220mm", height: "180mm");
            response = instance.CreateProduct1("123", product1);
            Assert.IsTrue(response.Success.Value);
            
            // Run the Imposition AI Plan tool with default profile and all devices
            // synchronously (see PlanStart1() to run Plan asynchronously)
            response = instance.Plan1("123", new PlanResource(stopMinutes: 5));
            
            // Get top 20 plan results, sorting is lowest cost be default
            List<PlanResultEntity> results = instance.GetPlanResults1("123",
                limit: 20, layouts: true, planThumb: true);
                
            // Apply the top result to the current project
            instance.ApplyPlanResult1(results[0].Id, "123");
            
            // Get current job report
            PhoenixProject project = instance.GetJob1("123", "V2");
            ...
        }
    }
}
```

## tilia Phoenix

Built from the ground up to cut costs, tilia Phoenix is a sophisticated true-AI planning and imposition application that has been boosting efficiencies for print service providers across all segments, from packaging, labels, commercial, corrugated, and wide format printing.

### Precise, Dynamic Imposition

Phoenix Imposition AI takes an entirely different approach to common imposition solutions. Rather than template-driven, it operates according to machine and production requirements to generate print-ready layouts on-the-fly. It factors in parameters, such as job specifications, print devices, finishing requirements, and delivery considerations, to search across potentially millions of possibilities for the optimal layout. When a final option has been selected, tilia Phoenix generates print-ready layouts and JDF or die instructions, and reports, for all devices in the production chain.

### Tight Integration

Uniting planning and prepress functions, tilia Phoenix can be integrated into your chosen workflow or MIS system to enable fast accurate estimates, shrink prepress time, automate error-prone tasks, maximize media usage, and reduce postpress complexity.
