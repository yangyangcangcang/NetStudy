# 1 SOA 

## 1.1 <a name="SOA定义">SOA定义</a>

面向服务架构，搭建分布式的设计思想，系统架构可以改进升级，做资源整合；可以把系统/功能模块拆分到不同的服务器，提升承载能力；

### 三种跨线程/跨服务器

- 数据库
- Remoting： 平台要求
- WebService/WCF/WebApi（对外是webapi，对内WCF, Webservice 都可以）

# 2 WebService 托管于IIS Web形式（ http/https）

## 2.1 WebService包含五个层次

1.  http协议 ：基于Http完成的请求/响应，数据是以Header/body去request，以header/body来response。通过code确认成功与失败
2. XML格式：跨平台（为什么不是json？在WebService出现时，还没有json）
3. SOAP协议：基于Http协议，header/body放入的是XML数据，SOAP协议是用来把一个操作翻译成XML，也可以把XML还原成操作；
4. WSDL:WebService的描述语言
5. UUDI:找服务的机制

**注意**：webSevice不能泛型

## 2.2 安全问题

1. 内部使用，不存在安全问题
2. Form  windows身份
3. 加个参数，token定时更新+沟通
4. 使用SoapHeader验证:



# 3 WCF

## 3.1 WCF支持的协议

http、tcp、pipe、msmq、p2p 



# 4 WebAPI

## 4.1 RESTful

是一种架构风格，以资源为视角，来描述服务的；在移动互联网时代，：json/xml来描述，http方法；统一数据操作

表现层的状态转换：资源；统一资源，URI：无状态

资源：实体都是资源，json/XMl/数据流

统一接口：CRUD,是通过http的method体现，get post put delete patch

URI：url

无状态：http无状态