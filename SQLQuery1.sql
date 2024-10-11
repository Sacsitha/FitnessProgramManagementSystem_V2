create table FitnessPrograms (FitnessProgramId nvarchar(10) Primary Key,
							  Title nvarchar(100),
							  Duration nvarchar(50),
							  Price decimal);

Insert into FitnessPrograms values('P001','weight Training','6 months',10);