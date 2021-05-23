# 1 Windows Powershell 

## 1.1 基本概念

1. 介绍

   问题：远程管理、自动化、windows版本差异

PS: Power shell 脚本简称



## 1.2   CmdLet

1. 每一个CmdLet都是按照命名标准命名     动词-名词 ； 例如： Get-Service //获取服务

2. 每一个CmdLet都有参数 ，实参    

   CmdLet   Parameter   Actual Parameter

​       Get-Service   -Name      alg 

[-name]<string> 必须参数

[-name<string>] 非必须

[-name<string[]>]   非必须 支持多个参数

[-AuthType <ADAuthType>{xxx|xxxx}]   非必须 限定在指定的几个值