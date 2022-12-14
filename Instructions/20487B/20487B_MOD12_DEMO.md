# Module 12: Scaling Services

## Lesson 2: Load Balancing

### Demonstration: Scaling out Web Applications in Microsoft Azure

#### Preparation Steps

For this demo, you will use the available virtual machine environment. Before you begin this demo, you must complete the following steps:
 1. On the host computer, click **Start**, point to **Administrative Tools**, and then click **Hyper-V Manager**.
 2. In Hyper-V Manager, click **MSL-TMG1**, and in the Actions pane, click **Start**.
 3. In Hyper-V Manager, click **20487B-SEA-DEV-A**, and in the Actions pane, click **Start**.
 4. In the **Actions** pane, click **Connect**. Wait until the virtual machine starts.
 5. Sign in using the following credentials:
    - User name: **Administrator**
    - Password: **Pa$$w0rd**

#### Demonstration Steps

1. On the Start screen, click the **Internet Explorer** tile.
2. Go to **http://manage.windowsazure.com**.
3. If a page appears, prompting you to provide your email address, type your email address, and then click **Continue**. Wait for the **Sign In** page to appear, type your email address and password, and then click **Sign In.**

   >**Note:** During the sign-in process, if a page appears prompting you to choose from a list of previously used accounts, select the account that you previously used, and then continue to type your credentials.

4. If the **Windows Azure Tour** dialog appears, close it.
5. Click **NEW** in the status bar, click **COMPUTE**, click **CLOUD SERVICE**, and then click **QUICK CREATE**.
6. In the **URL** text box, type **BlueYonderDemo12****_YourInitials_** (_YourInitials_ contains your initials).
7. In the **REGION** text box, select the region closest to your location.
8. Click **CREATE CLOUD SERVICE** and wait until the cloud service is created.
9. On the Start screen, click the **Visual Studio 2012** tile.
10. On the **File** menu, point to **Open**, and then click **Project/Solution**.
11. Go to **D:\AllFiles\Mod12\DemoFiles\ScalingWebApplications**.
12. Select the file **ScalingWebApplications.sln**, and then click **Open**.
13. In Visual Studio 2012, In the **Solution Explorer** pane, right-click the **WebApplication.Azure** project, and then click  **Publish**.
14. If you already added your Azure subscription information to Visual Studio 2012, select your subscription from the drop down list and skip to step 20.
15. In the **Publish Windows Azure Application** dialog box, click the **Sign in to download credentials** hyperlink.
16. If a page appears, asking for your email address, provide your email address, and then click **Continue**. Wait for the **Sign In** page to appear, type your email address and password, and then click **Sign In.**

   >**Note:** If during sign in, a page appears asking you to choose from a list of previously used accounts, select the account you previously used, and then continue to enter your credentials.

17. The publish settings file is generated, and a **Do you want to open or save...** dialog box appears at the bottom of the **Internet Explorer** window.
18. Click the arrow within the **Save** button, select **Save as**, specify the following location: **D:\AllFiles\Mod12\DemoFiles\ScalingWebApplications**, and then click **Save**.
19. Return to the **Publish Windows Azure Application** dialog box in Visual Studio 2012.
20. Click **Import**, type **D:\AllFiles\Mod12\DemoFiles\ScalingWebApplications**, and then press Enter.
21. Select the file that you downloaded in the previous step, and then click **Open**. Make sure that your subscription is selected under **Choose your subscription** section, and then click **Next**.
22. If the **Create Windows Azure Service** dialog box opens, type **blueyonderdemo12****_yourinitials_** (_yourinitials_ contains your initials, in lowercase) in the **Name** text box, select the region closest to your location from the **Location** drop down list, and then click **OK**.
23. On the **Common Settings** tab, click the **Cloud Service** drop-down, and then select **BlueYonderDemo12****_YourInitials_** (_YourInitials_ contains your initials).
24. Click **Publish** to start the publishing process.

   >**Note:** Consider running the previous steps before showing this demo, to reduce the waiting time while the web application is being deployed.

25. While the web application is being deployed, in the **Solution Explorer** pane, expand the **WebApplication.Azure** project, expand **Roles**, right-click **WebApplication**, and then click **Properties**.
26. In the **Properties** window, under **Instances**, verify that the **Instance count** value is set to **3**.
27. In the **Solution Explorer** pane, expand the **WebApplication** project, expand **Controllers**, and then double-click  **HomeController.cs**.
28. Locate the **Index** method and examine how the **ViewBag.Message** property is set. The **RoleEnvironment.CurrentRoleInstance.Id** property returns the role identifier which contains the instance number. By printing the instance number, you know which instance responded to the browser&#39;s request.
29. Wait for the publish process to complete and then, on the Start screen, click the **Internet Explorer** tile.
30. Go to **http://BlueYonderDemo12****_YourInitials_****.cloudapp.net** (_YourInitials_ contains your initials).
31. Verify that you see the title **Role instance is WebApplication_IN_ X** where _X_is replaced by the role instance (0, 1, or 2).
32. Press F5 to refresh the page, and verify the role instance number changes. If it does not show a new instance number, try pressing F5 again. You can press F5 several more times to show all instances (0, 1, and 2).
33. Go to **http://manage.windowsazure.com**.

  >**Note:** The browser should automatically sign you in to the portal. If you are redirected to a sign in page, type your email address and password, and then click **Sign in**.

34. Click **CLOUD SERVICES**, and then in the cloud services list click the name of your cloud service ??? **BlueYonderDemo12****_YourInitials_** (_YourInitials_ contains your initials).
35. On the **DASHBOARD** page, click **DELETE** in the taskbar, and then click **Delete the production deployment** (_YourInitials_ contains your initials).
36. When asked if you are sure you want to delete the production deployment, click **YES**.

## Lesson 4: Windows Azure Caching

### Demonstration: Using Microsoft Azure Caching

#### Preparation Steps

For this demo, you will use the available virtual machine environment. Before you begin this demo, you must complete the following steps:
 1. On the host computer, click **Start**, point to **Administrative Tools**, and then click **Hyper-V Manager**.
 2. In Hyper-V Manager, click **MSL-TMG1**, and in the Actions pane, click **Start**.
 3. In Hyper-V Manager, click **20487B-SEA-DEV-A**, and in the Actions pane, click **Start**.
 4. In the **Actions** pane, click **Connect**. Wait until the virtual machine starts.
 5. Sign in using the following credentials:
    - User name: **Administrator**
    - Password: **Pa$$w0rd**

#### Demonstration Steps

1. On the Start screen, click the **Visual Studio 2012** tile.
2. On the **File** menu, point to **Open**, and then click **Project/Solution**.
3. Go to **D:\Allfiles\Mod12\DemoFiles\WindowsAzureCaching\Begin\WindowsAzureCaching**.
4. Select the file **WindowsAzureCaching.sln**, and then click **Open**.
5. In the **Solution Explorer** pane, expand the **MvcApplication1** project, expand **Controllers**, and then double-click **LocationsController.cs**.
6. Examine the code in the **Get** method.  The method currently retrieves the Location entity from the database, but you will change this code to try and retrieve the entity from a distributed cache, before attempting to call the database.
7. In the **Solution Explorer** pane, expand the **MvcApplication1.Azure** project, right-click **Roles**, point to **Add**, and then click **New Worker Role Project**.
8. In the **Add New .NET Framework 4.5 Role Project** dialog box, click **Cache Worker Role**.
9. In the **Name** text box, type **CacheWorkerRole**, and then click **Add**.
10. On the **Build** menu, click **Build Solution**.
11. On the **View** menu, point to **Other Windows**, and then click **Package Manager Console**.
12. In **Package Manager Console**, type the following command, and then press Enter.

  ```cs
		install-package Microsoft.WindowsAzure.Caching -version 2.0.0.0 -ProjectName MvcApplication1
```
13. In the **Solution Explorer** pane, under the **MvcApplication1** project, double-click **Web.config**.
14. Locate the **&lt;dataCacheClients&gt;** section at the end of the file, and then in it locate the **&lt;autoDiscover&gt;** element. Change the value of the **identifier** attribute to **CacheWorkerRole**.

   >**Note:** This value is used to locate the Worker Role running the cache cluster.

15. Press Ctrl+S to save the file.
16. In the **Solution Explorer** pane, expand the **MvcApplication1** project, expand **Controllers**, and then double-click **LocationsController.cs**.
17. Add the following **using** directive to the beginning of the file:

  ```cs
		using Microsoft.ApplicationServer.Caching;
```
18. Locate the comment _// TODO: Place cache initialization here_, and then place the following code after it:

  ```cs
		DataCacheFactory cacheFactory = new DataCacheFactory();
        DataCache cache = cacheFactory.GetDefaultCache();
```
19. Locate the comment _// TODO: Find the location entity in the cache_, and then place the following code after it:

  ```cs
		string cacheKey = "location_" + id.ToString();
        location = cache.Get(cacheKey) as Location;
```
20. Add the following code between the _comment // TODO: Add the location to the cache_ and the end of the using statement:

  ```cs
		cache.Put(cacheKey, location);
```
21. Press Ctrl+S to save the file.
22. Click the first line of the code in the **Get** method, and then press F9 to add a breakpoint.
23. In the **Solution Explorer** pane, right-click the **MvcApplication1.Azure** project, and then click **Set as StartUp Project**.
24. Press F5 to start the Azure emulator.
25. After the browser opens, append the string **api/locations/1** to the address bar, and then press Enter. Visual Studio 2012 opens and stops on the breakpoint.
26. Press F10 several times, until you reach the **if** statement.
27. Hover over the **location** object, and then show students that its value is **null**.
28. Press F5 to continue running the application and display the browser. Verify you see the XML of the location entity.
29. Press F5 to refresh the page. Visual Studio 2012 opens and stops on the breakpoint.
30. Press F10 several times, until you reach the **if** statement.
31. Hover over the **location** object, and then show students that its value is set to a location entity.
32. Press F5 to continue running the application and display the browser. Verify you see the XML of the location entity.
33. Close the browser.

??2016 Microsoft Corporation. All rights reserved.

The text in this document is available under the  [Creative Commons Attribution 3.0 License](https://creativecommons.org/licenses/by/3.0/legalcode), additional terms may apply. All other content contained in this document (including, without limitation, trademarks, logos, images, etc.) are  **not**  included within the Creative Commons license grant. This document does not provide you with any legal rights to any intellectual property in any Microsoft product. You may copy and use this document for your internal, reference purposes.

This document is provided &quot;as-is.&quot; Information and views expressed in this document, including URL and other Internet Web site references, may change without notice. You bear the risk of using it. Some examples are for illustration only and are fictitious. No real association is intended or inferred. Microsoft makes no warranties, express or implied, with respect to the information provided here.
