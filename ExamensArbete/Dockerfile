# Use the official ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0

# Set the working directory to /app
WORKDIR /app

# Copy the published output of your application into the container
COPY ./bin/Release/net6.0/publish/ .

# Expose the port that your application will run on
EXPOSE 80

# Define the entry point for your application
ENTRYPOINT ["dotnet", "ExamensArbete.dll"]
