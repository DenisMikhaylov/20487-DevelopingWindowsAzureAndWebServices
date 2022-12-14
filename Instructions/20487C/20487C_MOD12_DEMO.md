# Module 12: Scaling Services

## Lesson 2: Load Balancing

### Demonstration: Scaling out Web Applications in Microsoft Azure

#### Preparation Steps

For this demo, you will use your Microsoft Azure account to create and configure a scalable Microsoft Azure App Service.

Before you begin this demo, you must complete the following steps:
 1. Go to **https://portal.azure.com**.
 2. If a page appears, prompting you to provide your email address, enter your email address, and then click **Continue**. Wait for the **Sign In** page to appear, enter your password, and then click **Sign In**.

   >**Note:** During the sign-in process, if a page appears prompting you to choose from a list of previously used accounts, select the account that you previously used, and then continue to enter your credentials.
 
#### Demonstration Steps

### Create the **Web App** in the **Azure Portal**

 1. To open the **App Services** pane, in the Azure portal, from the menu on the left side, select **App Services**.
 2. To create a new **App Service**, in the **App Services** pane, click **+ Add** on the left of the top tab.
 3. To open the **Web App** pane, in the **App Service** pane, click the **Web App** tile. 
 4. To create the new **Web App**, click **Create**.  
 5. In the **Web App create pane**:
   - In the **App Name** text box, type **ScalableAzureApp**.
  > **Note:** While editing the **App Name**, the text box may become red indicating that the name is unavailable. In this case, you can add your initials or some digits until you find an available name for the app you are creating.
  - Select the subscription you want to use, from the **Subscription** drop-down list.
  - For the web app you are creating, under **Resource Group**, create a new resource group or select an existing one.
  - Select the operating system as **Windows**.
  - Select an App Service plan or location for the web app you are creating.
  - For **Application Insights**, select the **Off** option.
  - To create the web app, click **Create**.
 6. To open the **App Services** pane again, select **App Services** from the menu on the left side. Select **ScalableAzureApp**.
 7. In the **ScalableAzureApp** options pane:
  - Select **Scale up** (App Service plan) and select the **B1 Basic** pricing tier. To set the selection, click the **Select** button.
  - To define the number of instances for the web app, select  **Scale out** (App Service plan), and in the **Configure** tab, set  **Instance count** to **2**. 
  - To download the profile of the web app to your computer, click **Overview**, and then click the **Get publish profile** tab.
  > **Note:** You will need this profile later to publish the project to the web app.


### Demonstration: Using Microsoft Azure Redis Cache

#### Preparation Steps

### Setup the **Redis Cache** using the **Azure Portal**

 1. To open a **New** pane, in the Azure portal, from the menu on the left side, select **+ New**.
 2. On the **New** pane, select **Databases**, and then from the **Databases** pane, select **Redis Cache**.
 3. In the **Redis Cache** pane:
  - Enter the name for the DNS, you can use the same name you used for the web app or you can choose any other name you prefer.
  - Select the **Subscription** you want to use.
  - Select the **Resource Group** to be the same one you used for the web app.
 > **Note:** It is recommended to configure your services to work in the same region.
  - Select the **Basic C0 250 MB Cache** pricing tier.
  - To set and deploy the Redis service, click **Create**.
  - Wait for Redis deployment to complete. It may take some time to complete the deployment.
 4. To get the **Redis** pane, from the menu on the left side, select **All resources**, and click the Redis service you have deployed. 
 5. From the **Redis**, select the **Access** keys,  copy the **Primary connection** string (**StackExchange.Redis**), and then save it.
 > **Note:** You will need this connection string later in order to configure the **ScalableAzureApp** project to use the **Redis Cache**. 


#### Demonstration Steps

### Build and Publish the **ScalableAzureApp Project** using **Visual Studio 2017**

 1. Open Visual Studio 2017.
 2. On the **File** menu, point to **Open**, and then click **Project/Solution**.
 3. Go to **[repositoryroot]\Allfiles\20487C\Mod12\DemoFiles\ScalableAzureApp**.
 4. Select the **ScalableAzureApp.sln** file and click **Open**.
 5. In Visual Studio 2017, in **Solution Explorer**, expand the **ScalableAzureApp** project, and then click **Web.config**.
 6. In **Web.config**, search for the **key="RedisConnectionString"** and replace its value with the connection string you saved while configuring **Redis Cache**. It should look something like the following code: 
``` 
	xml
       <appSettings>
         <add key="ReidsConnectionString" value="*pace the connection string here*" />
       </appSettings>
  ```
 7. In Visual Studio 2017, in **Solution Explorer**, right-click the **ScalableAzureApp** project, and then click **Publish**.
 8. In the **Publish**, from the listed targets, click the **Create new** profile, select the **Import** profile, and then click **Create Profile**. This will open **File Explorer**. Go to the folder where you saved the **Publish** profile and open it.
 9. Click the **Publish** option and wait for the web application to be deployed.
 10. When deploy is complete your web app should open in the browser.
 > **Note:** To enter the Azure portal, from the menu on the left side, select **App Services**, and then select **ScalableAzureApp**. To find the **URL** of the **ScalableAzureApp** web app, in the **ScalableAzureApp** pane, you can select **Overview**. To view or edit the scale of **ScalableAzureApp**, in the **ScalableAzureApp**pane, select the **Scale out** app service plan.   
 
 ??2018 Microsoft Corporation. All rights reserved.

The text in this document is available under the  [Creative Commons Attribution 3.0 License](https://creativecommons.org/licenses/by/3.0/legalcode), additional terms may apply. All other content contained in this document (including, without limitation, trademarks, logos, images, etc.) are  **not**  included within the Creative Commons license grant. This document does not provide you with any legal rights to any intellectual property in any Microsoft product. You may copy and use this document for your internal, reference purposes.

This document is provided &quot;as-is.&quot; Information and views expressed in this document, including URL and other Internet Web site references, may change without notice. You bear the risk of using it. Some examples are for illustration only and are fictitious. No real association is intended or inferred. Microsoft makes no warranties, express or implied, with respect to the information provided here.
