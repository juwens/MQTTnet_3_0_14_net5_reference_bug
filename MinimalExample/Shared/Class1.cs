using MQTTnet;
using System;

namespace Shared
{
    public static class Class1
    {
        public static MqttApplicationMessage GetMqttObject()
        {
            return new MqttApplicationMessage();
        }
    }
}
