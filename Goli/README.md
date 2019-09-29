# Goli
Goli is a .NET Core 2.1 Global Tool that prints a text in an awesome way !
## What is .NET Core global tools
A .NET Core global tool is a special NuGet package that contains a console application. When installing a tool, .NET Core CLI will download and make your console tool available as a new command.

## How to install it
The steps are very easy you only have to
* Check if .NET Core sdk version 2.1 installed on your system, you can download it from [Here](https://www.microsoft.com/net/download/dotnet-core/2.1) then check if the instalation has gone correctly by typing
      
      user$ dotnet --version
      user$ 2.1.402
* A single command allows you to download and install Goli
  
      user$ dotnet tool install --global Goli --version 1.0.0 
* Add the tool to the enironement variable 

Windows:

      setx PATH "$env:PATH;$env:USERPROFILE/.dotnet/tools"
    
Linux/macOS:

    echo "export PATH=\"\$PATH:\$HOME/.dotnet/tools\"" >> ~/.bash_profile
* Finaly run

      user$ Goli <Your Text>
* Support me by making a <img style="margin-bottom: -20px;" src="https://user-images.githubusercontent.com/24621701/44811262-193e6e00-abcc-11e8-8e61-e52d8c78d5c9.png" /> for the repo and thank you :D , If you want to contribute to the project and make it better, your help is very welcome. 
## Screenshot
![image](https://user-images.githubusercontent.com/24621701/46469552-c3984b00-c7a1-11e8-9e7c-9586b525d83a.png)

