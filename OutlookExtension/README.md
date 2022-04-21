# OutlookExtension
- This is outlook_redemption branch.
- In this branch we are trying to collect the data from outlook using the redemption interop APIs.
- Steps to enable warning on programmatic acces are as follows:
    - Close the running outlook instance if any.
    - Open the outlook in admin mode.
    - Go to File -> Options -> Trust Center -> Trust Center Settings -> Programmatic access -> Select Always warn me about suspicious activity.
- To check the bitness of the outlook application installed please open the task manager and check if the Outlook process running has 32-bit denotion in the process name, if not the process running is a 64 bit process.
- To register the Redemption binary, open the command prompt in the Dependencies folder of this project, and run the command 
        - 64 bit outlook installation: regsvr32.exe Redemption64.dll
        - 32 bit outlook installation: regsvr32.exe Redemption.dll

    - If regsvr32.exe is not added in the system path then the same could be found in this location:
        - %systemroot%\System32\
        - Open the terminal from here and fire the above mentioned commands with complete address to the redemption dlls.