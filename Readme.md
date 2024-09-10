<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585270/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T476835)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Diagram - Use DiagramOrgChartBehavior to Generate a Diagram from a Collection

This example uses the [DiagramOrgChartBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramOrgChartBehavior) to generate a hierarchical diagram from a data source or collection.

![image](https://github.com/DevExpress-Examples/wpf-diagram-use-diagramorgchartbehavior-to-generate-diagram-from-collection/assets/65009440/137aa033-f2cf-427f-b485-e7f715abe4dc)

## Implementation Details

1. Add the [DiagramOrgChartBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramOrgChartBehavior) to the [DiagramControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl).
2. Specify the following properties to map the behavior to data:
   * The [ItemsSource](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemsSource) property specifies a collection of source items.
   * [KeyMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.KeyMember) and [ParentMember](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramOrgChartBehavior.ParentMember) properties specify an item hierarchy for self-referential data.
3. Use the [Item Template Designer](https://docs.devexpress.com/WPF/117615/controls-and-libraries/diagram-control/data-binding/item-template-designer) to create "templates" for diagram items and connectors.
   This designer creates a [TemplateDiagram](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.TemplateDiagram) object that contains generated code with diagram shapes and connectors.

## Files to Review

* [Contact.cs](./CS/OrgChartBindingExample/Data/Contact.cs) (VB: [Contact.vb](./VB/OrgChartBindingExample/Data/Contact.vb))
* [ContactContextInitializer.cs](./CS/OrgChartBindingExample/Data/ContactContextInitializer.cs) (VB: [ContactContextInitializer.vb](./VB/OrgChartBindingExample/Data/ContactContextInitializer.vb))
* [MainViewModel.cs](./CS/OrgChartBindingExample/ViewModels/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/OrgChartBindingExample/ViewModels/MainViewModel.vb))
* [MainWindow.xaml](./CS/OrgChartBindingExample/MainWindow.xaml)

## Documentation

* [Generate Organization Charts](https://docs.devexpress.com/WPF/118579/controls-and-libraries/diagram-control/data-binding/generating-organization-charts)
* [Item Template Designer](https://docs.devexpress.com/WPF/117615/controls-and-libraries/diagram-control/data-binding/item-template-designer)

## More Examples

* [WPF Diagram - Use DiagramDataBindingBehavior to Generate a Diagram from a Collection](https://github.com/DevExpress-Examples/wpf-diagram-use-diagramdatabindingbehavior-to-generate-diagram-from-collection)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagram-use-diagramorgchartbehavior-to-generate-diagram-from-collection&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagram-use-diagramorgchartbehavior-to-generate-diagram-from-collection&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
