// https://maymay.net/blog/2008/06/15/ridiculously-simple-javascript-version-string-to-object-parser/

function parseVersionString(str) {
    if (typeof(str) != 'string') {
        return false;
    }
    var x = str.split('.');
    // parse from string or default to 0 if can't parse
    var maj = parseInt(x[0]) || 0;
    var min = parseInt(x[1]) || 0;
    var pat = parseInt(x[2]) || 0;
    return {
        major: maj,
        minor: min,
        patch: pat
    }
}

exports.getNewerVersions = function(versionArray, installedVersion) {

    var newerVersions = [];

    for (var i = 0; i < versionArray.length; i++) {

        var ver = parseVersionString(versionArray[i]);
        var curVer = parseVersionString(installedVersion);

        if (curVer.major < ver.major) {
            newerVersions.push(versionArray[i]);
        } else if (curVer.major == ver.major) {
            if (parseFloat(curVer.minor) < parseFloat(ver.minor)) {
                newerVersions.push(versionArray[i]);
            }else if(curVer.minor == ver.minor){
                if (parseFloat(curVer.patch) < parseFloat(ver.patch)) {
                    newerVersions.push(versionArray[i]);
                }
            }
        }

    }
    return newerVersions;
}
