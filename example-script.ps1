echo "This is a hello world batch file `n"
# Create a folder if it does not already exist
if (Get-Item -Path FolderA -ErrorAction Ignore) {
    echo "Main folder already exists `n"
    cd FolderA
}
else {
    echo "Creating the main folder `n"
    md FolderA
    cd FolderA
}

# Create a file
echo "Hello World" > testfile.txt

# Append Content to the file
echo "New Line" >> testfile.txt
echo A B C D >> testfile.txt

# Add content to the file - this overwrites the previous contents
echo "Last line" >> testfile.txt

# Display file contents
echo "`nContent of the Text File after appending text: `n"
cat testfile.txt

if (Get-Item -Path SubFolder -ErrorAction Ignore) {
    echo "`nSub Folder already exists in main folder `n"
}
else {
    echo "`nCreating sub folder `n"
    md SubFolder
}

# move to sub folder directory
cd .\SubFolder
echo "This is a text file in the sub folder" > introduction.txt

# Displays sub folder text file content
echo "`nContent of the Sub folder text file: `n"
cat introduction.txt

# move back to parent directory
cd ../..