# WPF-Data-driven-Dynamic-Layout

If using an excel file or CSV file, you need to do the following:

1. Download and install the 64-bit Office add-in @https://www.microsoft.com/en-us/download/details.aspx?id=13255 named "AccessDatabaseEngine_X64.exe" and install it.
2. Use the following provider value in the connection string:   "Microsoft.ACE.OLEDB.12.0"  (note the "Microsoft.Jet.OLEDB.4.0" will not work on 64-bit systems).
