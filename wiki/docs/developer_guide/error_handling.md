# Error Handling

This section covers some common errors we found and how we dealt with them.

## Errors while developing 

# Code Errors

Here are a few common errors that we noticed to occur:
* the C#-Script needs to derive from MonoBehavior, meaning that in the funktion definition of the C#-Script the MonoBehavior needs to be defined 
* when working with APIs, you have to specify the API URL not just in the code but also in the inspector window of the game Object you are assigning the script to

# Testing Errors

Here are a few common errors that we noticed during testing:
* GPS doesn't work: control in the settings if GPS is enabled, you have to give the permission manually 
