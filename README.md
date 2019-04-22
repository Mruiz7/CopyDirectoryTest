# CopyDirectory

Using Visual Studio (any version), write a file copying facility in C# called CopyDirectory. It MUST adhere to the following rules.

1) The copying function must reside in a separate assembly to the user interface.

2) You must write the user interface as either a) Console app b) Windows Forms app c) WPF app.

3) There should not be a concrete dependency between the copying assembly and the UI - i.e. you must properly separate the code. The copying assembly could be used in a web or desktop application.

4) Ideally, the UI must not “block” during the copy process.

5) Users must be able to pick or specify a source and target directory.

6) Copy all the files without replacing.

7) All files and folders (and their contents) must be copied from the source to the target.

8) You must implement a recursive algorithm to copy the files.

9) The application must work and not crash.