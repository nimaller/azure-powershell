### Example 1: Create a VolumeMount object for ContainerApp.
```powershell
New-AzContainerAppVolumeMountObject -MountPath "/mountPath" -VolumeName "VolumeName"
```

```output
MountPath  SubPath VolumeName
---------  ------- ----------
/mountPath         VolumeName
```

Create a VolumeMount object for ContainerApp.