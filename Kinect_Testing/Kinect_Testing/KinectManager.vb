Imports Microsoft.Kinect
Public Class KinectManager

    Public Sub ConnectSensor()
        Dim SensorCollection As KinectSensorCollection = KinectSensor.KinectSensors

        SensorCollection(0).Start()

        Dim Status As KinectStatus = SensorCollection(0).Status
    End Sub

    Public Function DetectHumanForm()

    End Function
End Class
