# Secure Password Generator.NET

##Description
_Secure Password Generator.NET_ is an efficient, easy-to-use, password generation utility which allows you to create highly secure passwords that are difficult to crack or guess.

###Dependencies
The application is written in C#, therefore it requires .NET Framework 4.0 (or above) to be installed in order to run it. To download .NET Framework, please go to (https://www.microsoft.com/net/download).

##How to Run
Simply download the source code, open it in Visual Studio and compile it. Upon success, _Secure Password Generator.NET_ will open as seen in the screenshot above.

##How to Use
_Secure Password Generator.NET_ is very easy to use. Just select the criteria for your password and click "Generate Password". Here is a breakdown of the all the options _Secure Password Generator.NET_ allows you to select:

* **Length**: Use this option to specify how long you want your password to be (default value is 4).
* **Include Letters**: Use this option to indicate whether you want to include letters in your password or not. This option has three sub-options: **All Upper**, **All Lower** and **Mix of Upper and Lower**.
* **Include Numbers**: Use this option to indicate that you want to include numbers in your password.
* **Include Symbols**: Use this option to indicate that you want to include symbols such as +, $ and - in your password. Click on **(?)** for a complete list of symbols. 

![logo](http://i.snag.gy/3F75G.jpg) **IMPORTANT**: Please note that at least ONE option (**Include Letters**, **Include Numbers** or **Include Symbols**) must be checked, or _Secure Password Generator.NET_ will automatically check **Include Letters** for you.

Here is a list of all the actions _Secure Password Generator.NET_ allows you to make:

* **Generate Password**: Click on this button (or press the 'Enter' key) to generate your password. 
* **Copy to Clipboard**: Click on this button to copy the most recently generated password to your clipboard.
* **Clear**: Use this option to clear the password field.
* **Exit**: Click on this button (or press the 'Esc' key) to exit the application. Please note that if your clipboard happens to contain the most recently generated password, _Secure Password Generator.NET_ will prompt you to clear your clipboard prior to exiting the application.

##Password Strength
Using numbers, symbols and mix of upper and lower case letters in your password makes it harder for someone to guess your password. Therefore, the more options you choose, the more secure the generated password will be. While _Secure Password Generator.NET_ can't tell you how strong your generated password is, there are several websites out there that serve that very purpose. Such websites include _Password Strength Checker_ (http://www.passwordmeter.com/) and _HOW SECURE IS MY PASSWORD?_ (https://howsecureismypassword.net/), just to name a couple.

##Comparison to Other Password Generators
There are literally hundreds (if not thousands) of password generators out there, so it's impossible to tell how _Secure Password Generator.NET_ compares to all of them. 

Having said that, _Norton Identity Safe Password Generator_ (https://identitysafe.norton.com/password-generator) is perhaps one of the most popular and trusted password generators out there. To test how _Secure Password Generator.NET_ compares to it, I generated passwords in both of them using the same exact options. In some cases, _HOW SECURE IS MY PASSWORD?_ showed that passwords generated using _Secure Password Generator.NET_ were just as secure as passwords generated using _Norton Identity Safe Password Generator_. In other cases, _HOW SECURE IS MY PASSWORD?_ showed passwords generated using _Secure Password Generator.NET_ were far more secure. 

##Final Thoughts
If you wish to contribute to this project, please feel free to clone this GitHub repository.
