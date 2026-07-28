// Pizza division for friends

int totalSlices = 15;
int friends = 4;

Console.WriteLine("We have " + totalSlices + " slices of pizza and " + friends + " friends.");

// Try to split the slices equally
int slicesPerPerson = totalSlices / friends;

Console.WriteLine("Each friend gets: " + slicesPerPerson + " slices.");

// Whats leftover ?

// Console.WriteLine(slicesPerPerson * friends);

int leftOverSlices = totalSlices - (slicesPerPerson * friends);
Console.WriteLine("We have " + leftOverSlices + " slices left. :)");

// Another way to calculate leftover...

int leftOverSlicesV2 = totalSlices % friends;

Console.WriteLine("We have " + leftOverSlicesV2 + " slices left. :)");

int leftOverSlicesV3 = totalSlices % slicesPerPerson; // this one cuts off the leftover (because of the way int slicesPerPerson = totalSlices / friends; is calculated )

Console.WriteLine("We have " + leftOverSlicesV3 + " slices left. :)");