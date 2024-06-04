# Message Analysis Sample Application using Azure Communication Services (WhatsApp) Integrated with Azure OpenAI

This sample application demonstrates the message analysis feature using Azure OpenAI within the Cross-Platform Messaging service of Azure Communication Services. It evaluates and understands the content of customer messages sent via platforms like WhatsApp.

## Features

This project provides the following features:
- Integration with Azure OpenAI for advanced message understanding.
- Analysis of customer messages for language detection, intent recognition, and key phrase extraction.
- Use of Azure Event Grid to handle messages received via WhatsApp.

## Prerequisites

- An Azure account with an active subscription. For details, see [Create an account for free](https://aka.ms/Mech-Azureaccount).
- [.NET SDK 7.0 or later](https://dotnet.microsoft.com/download).
- Azure Communication Services resource. For details, see [Create and manage Communication Services resources](https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/create-communication-resource).
- WhatsApp Channel under Azure Communication Services resource. For details, see [Register WhatsApp business account](https://learn.microsoft.com/en-us/azure/communication-services/quickstarts/advanced-messaging/whatsapp/connect-whatsapp-business-account).
- Azure OpenAI resource. For details, see [Create and deploy an Azure OpenAI Service resource](https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/create-resource).

## Setup

1. **Connect Azure Communication Services with Azure OpenAI Services:**
   Follow the instructions on the [Azure Communication Services and Azure Cognitive Services Integration page](https://learn.microsoft.com/en-us/azure/communication-services/concepts/call-automation/azure-communication-services-azure-cognitive-services-integration) to set up the connection between your Azure Communication Services and Azure OpenAI Services.

2. **Enable Message Analysis:**
   - Go to the **Channels** page of the **Advanced Messaging** tab in your Azure Communication Services resource.
   - Click on the channel you would like to enable message analysis on; a channel details page should pop up.
   - Toggle on **Allow Message Analysis**.
   - Select one of the connected Azure OpenAI services.
   - Choose the desired deployment model for the message analysis feature.

3. **Set Up Event Grid Subscription:**
   - Create an Event Grid subscription for `advancedmessagereceived` and `advancedmessageanalysiscompleted` events.
   - Choose **Web Hook** as the endpoint type.
   - Use the deployed web app URL + "/webhook" as the subscriber endpoint (e.g., `https://yourapp.azurewebsites.net/webhook`).

## Running the Sample Locally

To get up and running quickly, follow these steps:
1. Clone the repository:
    ```bash
    git clone https://github.com/Azure-Samples/communication-services-AI-message-analysis-sample.git
    ```
2. Navigate to the project directory:
    ```bash
    cd communication-services-AI-message-analysis-sample
    ```
3. Restore the project dependencies:
    ```bash
    dotnet restore
    ```
4. Build the project:
    ```bash
    dotnet build
    ```
5. Run the application:
    ```bash
    dotnet run
    ```
6. Open your browser and navigate to `https://localhost:7144` to interact with the application.

## Deployment to Azure Cloud

To deploy the web app, follow the quickstart guide: [Quickstart: Publish an ASP.NET web app](https://learn.microsoft.com/en-us/visualstudio/deployment/quickstart-deploy-aspnet-web-app?view=vs-2022&tabs=azure).

## Sign Up
To enroll in the limited preview of the WhatsApp Message Analysis feature, please complete the [sign up form](https://aka.ms/MessageAnalysisPreview). Access to this feature will be granted approximately one to two weeks after your application is submitted and reviewed.

## Resources

- [Azure Communication Services Documentation](https://docs.microsoft.com/en-us/azure/communication-services/)
- [Azure OpenAI Service Documentation](https://docs.microsoft.com/en-us/azure/cognitive-services/openai/overview)
- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-6.0)
- [Similar Sample Application](https://github.com/Azure-Samples/communication-services-AI-customer-service-sample)

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE.md) file for details.

## Contributing

Contributions are welcome! Please refer to the [CONTRIBUTING.md](CONTRIBUTING.md) file for guidelines.

## About

This sample application demonstrates the integration of Azure Communication Services and Azure OpenAI for message analysis within customer service scenarios.
