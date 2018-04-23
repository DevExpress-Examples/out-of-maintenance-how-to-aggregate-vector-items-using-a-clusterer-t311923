# How to aggregate vector items using a clusterer


This example demonstrates how to apply vector item clustering.


<h3>Description</h3>

<p>For this, assign a&nbsp;<strong>MapClustererBase</strong>&nbsp;class descendant to the&nbsp;<strong>MapDataAdapterBase.Clusterer</strong>&nbsp;property. Then, optionally specify the clusterer's properties.<br />For example, all predefined clusterers allow you to group items before clustering and customize the appearance of cluster representatives.&nbsp;<br />To group items, assign <strong>AttributeGroupProvider</strong>&nbsp;to the&nbsp;<strong>MapClusterer.GroupProvider&nbsp;</strong>property. Then, set the provider's&nbsp;<strong>AttributeName</strong>&nbsp;property to <strong>location</strong>.<br />To customize the appearance of cluster representatives, assign the required&nbsp;<strong>MapItemSettings</strong>&nbsp;class descendant object to the&nbsp;<strong>ClusterSettings&nbsp;</strong>property.</p>

<br/>


