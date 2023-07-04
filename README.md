
# Abstracta.JmeterDsl.Sample

This is a sample .Net project with simple Abstracta.JmeterDsl test plan invoking an invalid url.

This is a sample .Net project only containing a simple [Abstracta.JmeterDsl](https://abstracta.github.io/jmeter-dotnet-dsl) test to hit fake
site (https://myservice) which can help starting a performance testing project from scratch.

Check [Abstracta.JmeterDsl user guide](https://abstracta.github.io/jmeter-dotnet-dsl/guide) for more details jmeter-java-dsl and usage on existing Java projects.

## Pre requisites

* .Net 6.0+
* Java 11+

## Contents

| File                                                                                          | Description                                                                                                                                                                                                                 |
|-----------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| [PerformanceTest.cs](Abstracta.JmeterDsl.Sample/PerformanceTest.cs) | Class containing one simple example of performance test. You may create many NUnit tests as you want in one or multiple classes. Feel free to rename namespace according to your company or domain (eg: MyCompany.JmeterDsl.Sample). |
| [log4j2.xml](log4j2.xml)                                                   | [Log4j2 configuration file](https://logging.apache.org/log4j/2.x/manual/configuration.html) which allows tuning level (info, warn, debug), loggers (per package & class name) and destination of logs (stdout, file, etc).  |

## Executing tests

To execute the tests use IDE integrated features or use dotnet:

```powershell
dotnet test --logger "Console;verbosity=normal"
```