# LogCentral

## Development Process

### Part One, choosing project template
First I investigated variants of project template choices, I found two templates that seemed appropriate at first glance. Version is 3.1, since this is what happened to be installed on my private system already.

1. ASP.NET Core Web App (Model-View-Controller)
2. ASP.NET Core Web API

I chose 2. because the View seems unnessecary in the context, because the project should only concern itself with the API and therefore the View-part of number 1. seems rather unnecessary.

### Part Two, learning the API using Microsoft documentation
The guide I found on using the chosen template is https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio

And thus I started diving into creating a project, using the documentation to understand exactly how the .NET framework operates in this specific context (version 3.1, Core Web API, with my specific changes).

### Part Three, customizing to fit requirements

After following the tutorial far enough to have created an API that can both be queried for entires, and that allows for inserting entries (this is now tested), I start to customize the tutorial/template to fit the needs specified in the requirements document provided, 


### Part four, template has been customized, and proper test data must be made to show functionality

Once the project has been put into the proper state that at least somewhat covers the requirements, the tests must now customized to properly reflect requirements. 

Example test data inserted into database:

```json
[
    {
        "id": 1,
        "applicationId": "f6f3da33-1e09-463c-b51b-5f0a134079f4",
        "traceId": "ba2ea0d4-b353-48a8-b8e2-b66eae2104c7",
        "severity": "Low",
        "timestamp": "0001-01-01T00:00:00",
        "message": "Server Updated Successfully"
    },
    {
        "id": 2,
        "applicationId": "f6f3da33-1e09-463c-b51b-5f0a134079f4",
        "traceId": "320d8270-8703-4d15-919e-fb08fb741f36",
        "severity": "Medium",
        "timestamp": "0001-01-01T00:00:00",
        "message": "Server encountered error, restarting to attempt fix"
    },
    {
        "id": 3,
        "applicationId": "f6f3da33-1e09-463c-b51b-5f0a134079f4",
        "traceId": "f9d8bb3d-b730-4133-9eb6-2daceedb16ce",
        "severity": "High",
        "timestamp": "0001-01-01T00:00:00",
        "message": "Server crashed and is permanently offline"
    }
]
```

Each of the above entries is put into the database, one at a time, and finally the database is queried to retrieve all items. In case you are wondering why all entries have the same timestamp, you can considder the clock on the server submitting those completely broken.

Postman test collection present in file: LogCentral.postman_collection.json


### Evaluation // Considderations
- Going with version 3.1 of .NET was not the best idea, and in a real project I would definetly have retrieved the most recent packages instead.
- Should logging entries check recently added logs for identical loggings to avoid duplicates, do we explicitly want duplicated entries to allow for better debugging?
- Should applicationId be considdered a uuid (string), or a simple integer? equally for traceId, should this be string or int? Furthermore what options should Severety include? eg. "Low", "Medium", "High"?
- Should we considder the LogCentral to be on an internal network, and therefore have authentication be not required, or should we have authentication enabled? In this case, should each server have their own authentication key, or should we simply use one master key? Should we optimize for simplicity or security?


