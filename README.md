**Sample Usage**

    <accessRule>
        <rules>
            <!--+ write text on host -->
            <add group="test" action="{Write message just for you}" condition="{Host 67.199.52.87}" />
            <add group="test" action="Permit" />
            
            <!--+ allow only one host -->
            <add group="test2" action="Permit" condition="{Host 72.47.154.93}" />
            <add group="test2" action="{Write message for a range}" condition="{Range 72.47.154.90-72.47.154.95}" />
            <!--<add group="test2" action="{Write unauthorized}" condition="{MaskArea 72.47.154.0 0.0.0.255}" />-->
            <add group="test2" action="Permit" />
            
            <!--+ no output when no http referrer-->
            <add group="antiLeech" action="{Write}" condition="{HttpReferrer}" />
            <add group="antiLeech" action="Permit" />
            
            <!--+ block anyone using IE6; even then only allow people with 10.1.x.x addressing access a specific IP address-->
            <add group="restrict" action="{Redirect http://www.getfirefox.com/}" condition="{UserAgent Mozilla}" />
            <add group="restrict" action="Permit">
                <composite>
                    <add usage="from" value="{MaskArea 10.1.0.0 255.255.0.0}" />
                    <add usage="to" value="{Host 67.99.12.192}" />
                    <add value="{Subdomain www}" />
                </composite>
            </add>
            <add group="restrict" action="{Write Dude}" />
            
            <!--+ call the MyCustomConditionExecutor class; run EmailActionExecutor custom action -->
            <add group="customActionNotify" action="{Custom Email}" condition="{Custom MyCustom}" />
            <add group="customActionNotify" action="Permit" />
            
            <!--+ simply add a watcher -->
            <add group="watch" action="None" condition="{Custom MyCustom}" />
        </rules>
    </accessRule>
