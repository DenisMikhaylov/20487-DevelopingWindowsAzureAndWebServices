# Module 6: Hosting Services

# Lesson 1: Hosting Services On-Premises

### Demonstration: How to Host WCF Services in IIS

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
2. On the **File** menu, point to **New** , and then click **Project**.
3. In the **New Project** dialog box, on the navigation pane, expand the **Installed** node, expand the **Templates** node, and then expand the **Visual C#** node.
4. Click the **WCF** node, and then select **WCF Service Application** from the list of templates.
5. In the **Name** text box, type **MyIISService**.
6. In the **Location** text box, type **D:\Allfiles\Mod06\DemoFiles\WCF**.
7. Clear the **Create directory for solution** check box, and then click **OK**.
8. In Solution Explorer, under the **MyIISService** project, double-click **web.config**.

  >**Note** : The reason there is no &lt;services&gt; section in the &lt;system.serviceModel&gt; is because IIS automatically defines the base address according to the virtual directory where the services are hosted, and the default endpoint configuration of WCF therefore does not require any specific configuration for each endpoint.

9. In Solution Explorer, under the **MyIISService** project, right-click **Service1.svc** , and then click **View Markup**.

  >**Note** : When IIS receives a request addressed to the .svc file, it uses the value of the Service attribute from the file to know which service it needs to call.

10. In Solution Explorer, click the **MyIISService** project node.
11. To build and debug the application, press F5. After the application is built, a browser opens.
12. In the Internet Explorer window, locate the address bar. To the base address of the service, add the absolute path: **Service1.svc?wsdl**, and then press Enter. Review the WSDL file.

  >**Note** : Module 5, &quot;Creating WCF Services&quot; and Lesson 4, &quot;Consuming WCF Services&quot; in Course 20487 explains how to use WSDL to generate service proxies.

13. Return to Visual Studio and stop the debugger by pressing Shift+F5.
14. In Solution Explorer, right-click **MyIISService** project, and then click **Publish**. The **Publish Web** wizard opens.
15. On the **Profile** tab, click the combo box and select **&lt;New Profile&gt;**. A dialog box opens. In the text box, enter **MyProfile**, and then click **OK**.
16. On the **Connection** tab, click the **Publish Method** drop-down list and select **File system**.
17. Type **C:\inetpub\wwwroot\MyService** in the **Target Location** box, and then click **Publish**.
18. On the Start screen, click the **Internet Information Services (IIS) Manager** tile.
19. In the **Connections** pane, expand **SEA-DEV12-A (SEA-DEV12-A\Administrator)**.
20. If an **Internet Information Services (IIS) Manager** dialog box opens asking about the Microsoft Web Platform, click **No**.
21. In the **Internet Information Services (IIS) Manager Console** window, on the **Connections** pane, expand the **Sites** node, and then expand the **Default Web Site** node.
22. Right-click **MyService**, and then click **Convert to Application**.
23. In the **Add Application** dialog box, click **OK**.
24. On the Start screen, click the **Internet Explorer** tile.
25. In the browser, locate the address bar, type the path: **http://localhost/MyService/Service1.svc?wsdl**, and then press Enter.
26. Review the WCF service WSDL.

??2016 Microsoft Corporation. All rights reserved.

The text in this document is available under the  [Creative Commons Attribution 3.0 License](https://creativecommons.org/licenses/by/3.0/legalcode), additional terms may apply. All other content contained in this document (including, without limitation, trademarks, logos, images, etc.) are  **not**  included within the Creative Commons license grant. This document does not provide you with any legal rights to any intellectual property in any Microsoft product. You may copy and use this document for your internal, reference purposes.

This document is provided &quot;as-is.&quot; Information and views expressed in this document, including URL and other Internet Web site references, may change without notice. You bear the risk of using it. Some examples are for illustration only and are fictitious. No real association is intended or inferred. Microsoft makes no warranties, express or implied, with respect to the information provided here.
