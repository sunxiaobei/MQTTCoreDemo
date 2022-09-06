// See https://aka.ms/new-console-template for more information
using MqttClientConsole.Service;

Console.WriteLine("Hello, World! it's Client2");

MqttClientService mqttClientService = new MqttClientService();
mqttClientService.MqttClientStart();

Console.ReadLine();

mqttClientService.Publish("Hello, it's Client2");

Console.ReadLine();