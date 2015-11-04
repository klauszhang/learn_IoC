# learn_IoC

From course of pluralsight

dependencies can be seen in infrastructure > CustomerControllerFactory: 
there is a setting in Global.asax.cs to say current controller builder is CustomerControllerFactory

There is a fake data -> ProteinData to pretend the database. 
the repository reads the data and is injected into ProteinTrackingService. 
then ProteinTrackingService is injected into ProteinTrackerController via customizing IControllerFactory (see above).

all these is done manually without using nuget to show how it works. The view isn't been implemented because it is not necessary.
