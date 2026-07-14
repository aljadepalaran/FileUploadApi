# FileUploadApi
This is a basic web api that allows form data to be submitted and it returns the content of the form data.

## Example cURL
curl --location 'localhost:5271/upload' \
--form 'file=@"./file.txt"'