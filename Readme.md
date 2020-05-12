<!-- default file list -->
*Files to look at*:

* [Contact.cs](./CS/OrgChartBindingExample/Data/Contact.cs) (VB: [ContactContextInitializer.vb](./VB/OrgChartBindingExample/Data/ContactContextInitializer.vb))
* [ContactContextInitializer.cs](./CS/OrgChartBindingExample/Data/ContactContextInitializer.cs) (VB: [ContactContextInitializer.vb](./VB/OrgChartBindingExample/Data/ContactContextInitializer.vb))
* [Gender.cs](./CS/OrgChartBindingExample/Data/Gender.cs) (VB: [Gender.vb](./VB/OrgChartBindingExample/Data/Gender.vb))
* [MainWindow.xaml](./CS/OrgChartBindingExample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/OrgChartBindingExample/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/OrgChartBindingExample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/OrgChartBindingExample/MainWindow.xaml.vb))
* [MainViewModel.cs](./CS/OrgChartBindingExample/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/OrgChartBindingExample/ViewModels/MainViewModel.vb))
<!-- default file list end -->
# How to generate a diagram from a collection using DiagramOrgChartBehavior


This example demonstrates how to generate a diagram from a certain source/collection using DiagramOrgChartBehavior. To provide DiagramOrgChartBehavior with the required source, use the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_ItemsSourcetopic.aspx">ItemsSource</a> property. To build and display relationships between diagram shapes, use the <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_KeyMembertopic.aspx">KeyMember</a> and <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramOrgChartBehavior_ParentMembertopic.aspx">ParentMember</a> properties. The <a href="https://documentation.devexpress.com/WPF/DevExpressXpfDiagramDiagramDataBindingBehaviorBase_TemplateDiagramtopic.aspx">TemplateDiagram</a> property contains DiagramItems used to generate and show shapes and connectors according to the bound collection.

<br/>


