This is a super basic sample application that shows the simplest way to get two Service Fabric services to communicate.

If you want to see the exact code you need, look at the [diff between the default services and the code I added/changed](https://github.com/ytechie/service-fabric-remoting-sample/commit/32cac934a3c0efc7e0582e36f10a845884adc28f).

A few things to note:

* The easiest way to get services to communicate is through remoting. It's easy, and the awesome Service Fabric team put in default implementations to make this easy.
* You can certainly use HTTP, TCP, WCF, or any protocol of your choice for communication, but why do you care? You generally should care about the **what**, not the **how**.

Here is an overview of what I had to do:

1. Create 2 Service Fabric services. I basically called mine `client` and `server`. Just roll with it.
1. In the *server* service, you'll need to define an interface for your service.
1. Tell the service how to supply a remoting listener.
1. Have the client reference the server, or at least reference the interface.
1. In the *client* service, create a proxy.
1. Call your methods using the proxy implementation.

Again, the exact code needed is [available here](https://github.com/ytechie/service-fabric-remoting-sample/commit/32cac934a3c0efc7e0582e36f10a845884adc28f#diff-b4c4fff53bc8baddb947e9b3ac435312R10).
