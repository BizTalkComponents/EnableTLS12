
# Enable TLS 1.2
Enable TLS 1.2 is a WCF endpoint behavior extensions that enables security protocol TLS1.2, it is designed for being used with BizTalk2013.
All you need is to add this extension to your WCF behavior list.

## Installation
Download and install the latest release.
This extension is designed to be used with BizTalk, but it can also be used with other applications.
There are two ways to add this extension to the configuration, it can be added to the global machine.config file, or it can be added to the host instance only.

###  Adding to machine.config
the extension must be added to boath .Net framework versions (32 bit and 64 bit).


`%windir%\Microsoft.Net\Framework\<.NET Version>\config\machine.config`

`%windir%\Microsoft.Net\Framework64\<.NET Version>\config\machine.config`


locate behaviorExtensions section and add the following line

    <add name="Enable_TLS12" type="BizTalkComponents.WCFCustomExtensions.EnableTLS12Behaviour.EnableTLS12BehaviorExtension, BizTalkComponents.WCFCustomExtensions.EnableTLS12Behaviour, Version=1.0.0.0, Culture=neutral, PublicKeyToken=5bef280215158741" />
### Adding to BizTalk Host Instance
In BizTalk Administrator Console, go to Platform Settings --> Adapters  and select the WCF adapter you would like to add the extension to, then select the send handler you want to make the extension available with, right click on it and then select properties, Click Properties button in Adapter Handler Properties, then select WCF extensions, copy the code below to a new Xml file then click on Import.

	<configuration>
	  <system.serviceModel>
	    <extensions>
	      <behaviorExtensions>
	            <add name="Enable_TLS12" type="BizTalkComponents.WCFCustomExtensions.EnableTLS12Behaviour.EnableTLS12BehaviorExtension, BizTalkComponents.WCFCustomExtensions.EnableTLS12Behaviour, Version=1.0.0.0, Culture=neutral, PublicKeyToken=5bef280215158741" />
	      </behaviorExtensions>
	    </extensions>
	  </system.serviceModel>
	</configuration>