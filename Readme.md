<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128571122/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T311923)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/ClustererSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/ClustererSample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/ClustererSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/ClustererSample/MainWindow.xaml.vb))
<!-- default file list end -->
# How to aggregate vector items using a clusterer


This example demonstrates how to apply vector item clustering.


<h3>Description</h3>

<p>For this, assign a&nbsp;<strong>MapClustererBase</strong>&nbsp;class descendant to the&nbsp;<strong>MapDataAdapterBase.Clusterer</strong>&nbsp;property. Then, optionally specify the clusterer's properties.<br />For example, all predefined clusterers allow you to group items before clustering and customize the appearance of cluster representatives.&nbsp;<br />To group items, assign <strong>AttributeGroupProvider</strong>&nbsp;to the&nbsp;<strong>MapClusterer.GroupProvider&nbsp;</strong>property. Then, set the provider's&nbsp;<strong>AttributeName</strong>&nbsp;property to <strong>location</strong>.<br />To customize the appearance of cluster representatives, assign the required&nbsp;<strong>MapItemSettings</strong>&nbsp;class descendant object to the&nbsp;<strong>ClusterSettings&nbsp;</strong>property.</p>

<br/>


