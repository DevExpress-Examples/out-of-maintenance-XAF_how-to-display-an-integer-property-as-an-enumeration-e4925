;#DropDB IntAsEnumExampleEasyTest

#Application IntAsEnumExample.Win
#Application IntAsEnumExample.Web

#IfDef IntAsEnumExample.Win

*Action About...
 
*Action OK

#EndIf

#IfDef IntAsEnumExample.Web

*Action Choose Theme(Black Glass)

#EndIf
