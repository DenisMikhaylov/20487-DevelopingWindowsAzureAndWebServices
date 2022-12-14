# Module 10: Monitoring and Diagnostics

# Lesson 2: Configuring Service Diagnostics

### Demonstration: Tracing WCF Services

#### Preparation Steps

For this demo, you will use the available virtual machine environment. Before you begin this demo, you must complete the following steps:
 1.	On the host computer, click **Start**, point to **Administrative Tools**, and then click **Hyper-V Manager**.
 2.	In Hyper-V Manager, click **MSL-TMG1**, and in the Actions pane, click **Start**.
 3.	In Hyper-V Manager, click **20487B-SEA-DEV-A**, and in the Actions pane, click **Start**.
 4.	In the **Actions** pane, click **Connect**. Wait until the virtual machine starts.
 5.	Sign in using the following credentials:
    - User name: **Administrator**
    - Password: **Pa$$w0rd**

#### Demonstration Steps

1. On the Start screen, click the **Visual Studio 2012** tile.
2. On the **File** menu, point to **Open**, and then click **Project/Solution**.
3. Go to **D:\Allfiles\Mod10\DemoFiles\TracingWCFServices\CalcService**.
4. Select the file **CalcService.sln**, and then click **Open**.
5. In Solution Explorer, under the **CalcService** project, right-click **Web.config**, and then click **Edit WCF Configuration**.
6. In the **Configuration** pane, click **Diagnostics**.
7. Click **Enable Tracing**.
8. Click **Enable MessageLogging**.
9. In the **Configuration** pane, expand the **Diagnostics** node, and then click the **Message Logging** node
10. In the pane on the right, locate the **LogEntireMessage** property in the property grid. If it is set to **False**, set it to **True**.
11. On the **File** menu, click **Save**.
12. On the **File** menu, click **Exit**.
13. Return to Visual Studio 2012 and in Solution Explorer, under the **CalcService** project, right-click **SimpleCalculator.svc** and then click **Set As Start Page**.
14. Press Ctrl+F5. The WCF Test Client window will open.
15. Double-click the **Div** node in the pane to the left.
16. Set the **a** property to **4** and the **b** property to **2** , and click **Invoke**. If a **Security Warning** dialog box appears, click **OK**.
17. Change the **b** property to **0**, and click **Invoke**. If a **Security Warning** dialog box appears, click **OK**. A dialog box with an exception will be shown.
18. Click **Close** and then close the WCF Test Client window.
19. On the Start screen, click the **Computer** tile, and go to **D:\Allfiles\Mod10\DemoFiles\TracingWCFServices\CalcService\CalcService**.
20. Double-click **web_tracelog.svclog**. This will open the Microsoft Service Trace Viewer application.
21. On the **File** menu, click **Add**.  
In the **Open** dialog box, go to **D:\Allfiles\Mod10\DemoFiles\TracingWCFServices\CalcService\CalcService**, click **web_messages.svclog**, and then click **Open**.

22. Click the **Activity** tab to view the trace logs.
23. Click the line in red that says **Process action http://tempuri.org/ICalc/Div**.
24. On the pane to the right, click the red line that starts with **Handling an exception**.  
On the **Formatted** tab, show the **Exception Information** group.

25. On the pane to the right, click the line that says **Message Log Trace**.
26. Click the **Message** tab.
27. Show the message content.
28. Close the Microsoft Service Trace Viewer window.


# Lesson 3: Monitoring Services Using Windows Azure Diagnostics

### Demonstration: Configuring Microsoft Azure Diagnostics

#### Preparation Steps

For this demo, you will use the available virtual machine environment. Before you begin this demo, you must complete the following steps:
 1.	On the host computer, click **Start**, point to **Administrative Tools**, and then click **Hyper-V Manager**.
 2.	In Hyper-V Manager, click **MSL-TMG1**, and in the Actions pane, click **Start**.
 3.	In Hyper-V Manager, click **20487B-SEA-DEV-A**, and in the Actions pane, click **Start**.
 4.	In the **Actions** pane, click **Connect**. Wait until the virtual machine starts.
 5.	Sign in using the following credentials:
    - User name: **Administrator**
    - Password: **Pa$$w0rd**

#### Demonstration Steps

1. On the Start screen, click the **Visual Studio 2012** tile.
2. On the **File** menu, point to **Open** , and then click **Project/Solution**.
3. Go to **D:\Allfiles\Mod10\DemoFiles\AzureDiagnostics\Begin\AzureDiagnostics**.
4. Select the file **AzureDiagnostics.sln**, and then click **Open**.
5. In Solution Explorer, expand the **AzureDiagnostics** project, expand **Roles**, right-click the **DiagnosticsWebRole** role, and then click **Properties**.
6. In the Properties window, on the **Configuration** tab, under **Diagnostics**, select the **Custom plan** option, and then click **Edit**.
7. In the **Diagnostics configuration** dialog box, on the **Application logs** tab, change the **Log level** from **Error** to **Verbose**.
8. Click the **Log directories** tab, and then in the **Transfer period** combo box, select **1**.
9. In the **Buffer size** box, type **1024**.
10. In the **Directories** grid, in the **IIS logs** row, type **1024** in the **Directory quota (MB)** column.
11. Click **OK**, and then press Ctrl+S to save the changes to the role configuration.
12. In Solution Explorer, right-click the **AzureDiagnostics** project and click **Set as StartUp Project**.
13. Press Ctrl+F5 to run the project without debugging.
14. In Internet Explorer write a message in the **Log Text** box. Click **Write to trace provider**, which will write the text to the trace log.
15. Close the browser and return to Visual Studio 2012.
16. On the **View** menu, click **Server Explorer**.
17. In Server Explorer, expand **Windows Azure Storage**, and then expand**(Development)**.
18. Right-click **Tables**, and then click **Refresh**.
19. Expand the **Tables** node, and double-click **WADLogsTable**. If you do not see the **WADLogsTable**, it might be that the logs have not been uploaded yet to the table storage. Wait one minute for the logs to upload, and then repeat step 18 to refresh the tables list.
20. Scroll right and explore the table by looking at the **Message** column which presents the value of the logged events.

    >**Note:** Log data will be transferred to the Azure storage emulator once a minute. If you cannot see the Log data, please wait one minute before checking again.

21. In Server Explorer, expand **Windows Azure Storage**, then expand **Development**, and then expand **Blobs**. Double-click **wad-iis-logfiles**.
22. Right-click the first line and then click **Open**. If you are asked to pick the application to open this file type, click **More options** and choose to open the file with Notepad.
23. Inspect the file&#39;s content.
24. Close **Notepad**.


# Lesson 4: Collecting Windows Azure Metrics

### Demonstration: Viewing Microsoft Azure Web App Metrics

#### Preparation Steps

For this demo, you will use the available virtual machine environment. Before you begin this demo, you must complete the following steps:
 1.	On the host computer, click **Start**, point to **Administrative Tools**, and then click **Hyper-V Manager**.
 2.	In Hyper-V Manager, click **MSL-TMG1**, and in the Actions pane, click **Start**.
 3.	In Hyper-V Manager, click **20487B-SEA-DEV-A**, and in the Actions pane, click **Start**.
 4.	In the **Actions** pane, click **Connect**. Wait until the virtual machine starts.
 5.	Sign in using the following credentials:
    - User name: **Administrator**
    - Password: **Pa$$w0rd**

#### Demonstration Steps

1. On the Start screen, click the **Internet Explorer** tile.
2. Go to **http://manage.windowsazure.com**.
3. If a page appears, prompting you to enter your email address, type your email address, and then click **Continue**.
4. Wait for the **Sign In** page to appear, type your email address and password, and then click **Sign In.**

   >**Note:** During the sign-in process, if a page appears prompting you to choose from a list of previously used accounts, select the account that you previously used, and then continue to type your credentials.

5. If the **Windows Azure Tour** dialog appears, close it.
6. In the navigation pane, click **WEB APPS**, click **NEW**, and then click **QUICK CREATE**.
7. Enter the following information:

    - URL: **metricsdemoYourInitials** (Replace _YourInitials_ with your initials).
    - APP SERVICE PLAN: select **Create new App Service plan.**
    - REGION: Select the region closest to your location.

8. Click **CREATE WEB APP**, and wait for the web app to be created.
9. On the **web apps** page, click the name of the new web app.
10. On the **DASHBOARD** tab, click **Download the publish profile**.
11. Save the file to **D:\Allfiles\Mod10\DemoFiles\WebSiteMonitoring\SimpleWebApplication.**
12. Click the **MONITOR** tab, and then click **ADD METRICS**.
13. In the **Choose Metrics** dialog box, select the **Http Successes** metric, and remove the selection from all other selected metrics.
14. Click **Yes** to confirm.
15. If the circle to the left of the metric you added is grey, click the circle to display the metric in the graph.
16. On the Start screen, click the **Visual Studio 2012** tile.
17. On the **File** menu, point to **Open**, and then click **Project/Solution**.
18. Go to **D:\Allfiles\Mod10\DemoFiles\WebSiteMonitoring\SimpleWebApplication**.
19. Select the file **SimpleWebApplication.sln**, and then click **Open**.
20. In Solution Explorer, right click the **SimpleWebApplication** project, and then click **Publish**.
21. In the **Publish Web** dialog box, click **Import**, select the **Import from a publish profile file** option, and then click **Browse**.
22. Go to the **D:\Allfiles\Mod10\DemoFiles\WebSiteMonitoring\SimpleWebApplication** folder, select the publish profile file you downloaded previously, and then click **Open**.
23. Click **OK** to close the **Import Publish Profile** dialog box, and then click **Publish**. Wait for the publish process to complete and for a browser to open.
24. In the browser, click the **ClickHere** button several times.
25. Go back to the Azure portal web page, and on the **MONITOR** tab, click the refresh icon in the top right corner of the graph.
26. Verify that the number of **Http Successes** increased.

??2016 Microsoft Corporation. All rights reserved.

The text in this document is available under the  [Creative Commons Attribution 3.0 License](https://creativecommons.org/licenses/by/3.0/legalcode), additional terms may apply. All other content contained in this document (including, without limitation, trademarks, logos, images, etc.) are  **not**  included within the Creative Commons license grant. This document does not provide you with any legal rights to any intellectual property in any Microsoft product. You may copy and use this document for your internal, reference purposes.

This document is provided &quot;as-is.&quot; Information and views expressed in this document, including URL and other Internet Web site references, may change without notice. You bear the risk of using it. Some examples are for illustration only and are fictitious. No real association is intended or inferred. Microsoft makes no warranties, express or implied, with respect to the information provided here.
