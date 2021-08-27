<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585270/16.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T476835)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Contact.cs](./CS/OrgChartBindingExample/Data/Contact.cs) (VB: [Contact.vb](./VB/OrgChartBindingExample/Data/Contact.vb))
* [ContactContextInitializer.cs](./CS/OrgChartBindingExample/Data/ContactContextInitializer.cs) (VB: [ContactContextInitializer.vb](./VB/OrgChartBindingExample/Data/ContactContextInitializer.vb))
* [Gender.cs](./CS/OrgChartBindingExample/Data/Gender.cs) (VB: [Gender.vb](./VB/OrgChartBindingExample/Data/Gender.vb))
* [MainWindow.xaml](./CS/OrgChartBindingExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/OrgChartBindingExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/OrgChartBindingExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/OrgChartBindingExample/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/OrgChartBindingExample/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/OrgChartBindingExample/ViewModels/MainViewModel.vb))
<!-- default file list end -->
# How to generate a diagram from a collection using DiagramOrgChartBehavior


This example demonstrates how to generate a diagram from a certain source/collection using DiagramOrgChartBehavior. To provide DiagramOrgChartBehavior with the required source, use the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_ItemsSourcetopic.aspx">ItemsSource</a> property. To build and display relationships between diagram shapes, use the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_KeyMembertopic.aspx">KeyMember</a> and <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramOrgChartBehavior_ParentMembertopic.aspx">ParentMember</a> properties. The <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_TemplateDiagramtopic.aspx">TemplateDiagram</a> property contains DiagramItems used to generate and show shapes and connectors according to the bound collection.

<br/>


