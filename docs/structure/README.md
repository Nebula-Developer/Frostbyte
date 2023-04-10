# [Docs](/docs/README.md) - Structure documentation

This is the structure documentation for Frostbyte. All unreleased features are first documented here, and then moved into the main documentation when they are released. If you would like to add a feature to Frostbyte, please first modify the documentation blueprint ([here](blueprint.md)), and then add the feature to the code. If you would like to add a feature to Frostbyte, but do not know how to implement it, please contact me at [nebuladev.contact@gmail.com](mailto:nebuladev.contact@gmail.com).

<br>

## Contents

- [Filesystem](filesystem/README.md) - Contains classes that are used to interact with the host-OS filesystem, which is accessed by Frostbyte primarily through the `Drive` class.

- [Root](root/README.md) - Contains classes that are primarily used during the boot sequence of Frostbyte, and will initialize most of the operating system.