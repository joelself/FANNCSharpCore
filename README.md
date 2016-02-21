`FANN C# Core`
====
## FANN

**Fast Artificial Neural Network (FANN) Library** is a free open source neural network library, which implements multilayer artificial neural networks in C with support for both fully connected and sparsely connected networks.

Cross-platform execution in both fixed and floating point are supported. It includes a framework for easy handling of training data sets. It is easy to use, versatile, well documented, and fast.

## `FANN C# Core`
**FANN C# Core** is a wapper around FANN that lets you use the FANN libraries from C# using the .NET Core framework. This will maybe make this library cross-platform. I'm not really clear on how that works yet.  This is just like [**FANN C#**](https://github.com/joelself/FannCSharp), but for .NET Core and possibly for multiple platforms.

## Current Progress
Nothing has been ported over yet. Here is a list of things I think I have to do:
- [ ] Import all projects (except for example projects at first) into the new FANNCSharpCore solution.
- [ ] Delete the default project that was created when I created the FANNCSharpCore solution
- [ ] Follow [the guide here](https://github.com/dotnet/corefx/blob/master/Documentation/project-docs/getting-started-core.md) on ading support for the Platform Standard and update my packages to the latest
- [ ] Write my own `ApplicationException` (doesn't have to fancy)
- [ ] Write my own `SystemException` (also doesn't have to be fancy)
- [ ] Copy the [Mono project's `HandleRef`](https://github.com/mono/mono/blob/master/mcs/class/corlib/System.Runtime.InteropServices/HandleRef.cs) into my own `HandleRef` implementation
- [ ] Modify the `CleanUpForSwig` application to replace all `ApplicationException`s `SystemException`s and `HandleRef`s with my own implementations.

## To Learn More About FANN

To get started with FANN, go to the [FANN help site](http://leenissen.dk/fann/wp/help/), which will include links to all the available resources. For more information about FANN, please refer to the [FANN website](http://leenissen.dk/fann/wp/)
