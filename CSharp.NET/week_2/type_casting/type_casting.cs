// Implicit conversion (automatic)
float float1 = 123.12F;
double double1 = float1;

// Explicit conversion (manual)
double double2 = 213.2;
float float2 = (float)double2;

// Using helper classes for conversion
float2 = Convert.ToSingle(double2);
