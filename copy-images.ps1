$sourceRoot = 'C:\Users\panka\OneDrive\Desktop\Project\Classical Soch\IMages'
$destRoot = 'C:\Users\panka\OneDrive\Desktop\Project\Classical Soch\ClassicalSoch\wwwroot\Images'
$map = @{
    'HomepageMain.jpeg' = 'hero-banner.jpg'
    'ProjectDescriptiveImage.jpeg' = 'about-salon.jpg'
    'PackageImageForMan.jpeg' = 'package1.jpg'
    'PackageImageforWomen.jpeg' = 'package2.jpg'
    'SiderGeints.jpeg' = 'package3.jpg'
    'SiderLedies.jpeg' = 'service-men.jpg'
    'PackageImageForMan.jpeg' = 'course1.jpg'
    'PackageImageforWomen.jpeg' = 'course2.jpg'
    'HomepageMain.jpeg' = 'gallery1.jpg'
    'ProjectDescriptiveImage.jpeg' = 'gallery2.jpg'
    'PackageImageForMan.jpeg' = 'facial.jpg'
    'PackageImageforWomen.jpeg' = 'hair-color.jpg'
    'SiderGeints.jpeg' = 'spa.jpg'
    'HomepageMain.jpeg' = 'bridal-makeup.jpg'
    'ProjectDescriptiveImage.jpeg' = 'testimonial1.jpg'
    'SiderLedies.jpeg' = 'testimonial2.jpg'
}

foreach ($key in $map.Keys) {
    $source = Join-Path $sourceRoot $key
    $dest = Join-Path $destRoot $map[$key]
    if (Test-Path $source) {
        Copy-Item -Path $source -Destination $dest -Force
        Write-Host "Copied $key -> $($map[$key])"
    } else {
        Write-Host "Missing source: $key"
    }
}

Get-ChildItem $destRoot | Select-Object Name, Length | Sort-Object Name | Format-Table
