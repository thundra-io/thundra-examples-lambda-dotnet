# Thundra Logging Example

This is a simple example to demonstrate logging in Thundra.

You will learn how to observe the invocation metrics, especally logs of lambda functions with Thundra using **sample logs**.

The example has a hard coded list of albums, and the handler method in the Functions class creates logs of varrying levels
with the message being different pieices of album information. The default trace level is 'Trace' with level 0.
Please read the [log Support documentation](https://docs.thundra.io/v1.0.0/docs/dotnet-log-support) of Thundra's .NET agent to understand how Logs have been used in the project.

#### 1 - Configuration

Make the following configurations in the `src/ThundraLoggingExample` directory, to the 'aws-lambda-tools-defaults.json' file

- Add Api Key
  To the `environment-variables` tag.

- Add your region
  Add your preferred AWS region to the `region` tag.

- Add an IAM role
  To create an IAM role:
  1. Sign in to the AWS Management Console and open the IAM console at https://console.aws.amazon.com/iam/.
  2. Follow the steps in IAM Roles in the IAM User Guide to create an IAM role (execution role). As you follow the steps to create a role, note the following:
     _ In Select Role Type, choose AWS Service Roles, and then choose AWS Lambda.
     _ In Attach Policy, choose the AWSLambdaBasicExecutionRole policy.
     After creating your role, add it to the `profile` tag.

#### 2 - Deploy

Deploy the .Net Lambda function using the [AWS dotnet tools](https://www.nuget.org/packages/Amazon.Lambda.Tools/) with the command below:

```bash
dotnet lambda deploy-function LoggingFunction
```

#### 3 - Invoke

Invoke the .Net Lambda function using the [AWS dotnet tools](https://www.nuget.org/packages/Amazon.Lambda.Tools/) with the command below:

```bash
dotnet lambda invoke-function LoggingFunction --payload "{\"id\":\"3\"}"
```

#### 4 - Enjoy your flight with Thundra!

Visit [Thundra](https://www.thundra.io/) to observe your metrics. It might take 1-2 minutes to be visible.