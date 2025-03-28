#!/usr/bin/env python

####+BEGIN: b:prog:file/particulars :authors ("./inserts/authors-mb.org")
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars |]]* :: Authors, version
** This File: /bisos/git/auth/bxRepos/bisos-pip/binsprep/py3/bin/exmpl-func-binsPrep.cs
** Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
#+end_org """
####+END:

""" #+begin_org
* Panel::  [[file:/bisos/panels/bisos-core/capability/collectiveCapabilities/siteRegistrarCapability/_nodeBase_/fullUsagePanel-en.org]]
* Overview and Relevant Pointers
#+end_org """

from bisos.debian import systemdSeed
from bisos.basics import pathPlus

def sysdUnitFileFunc() -> str | None:
    """Produce the unit file as a string. execPath can be different for testing vs stationable."""

    if ( execPath := pathPlus.whichBinPath("svcPerfSiteRegistrars.cs",)
    ) is None: return None

    templateStr = f"""
[Unit]
Description=Site Registrar Service
Documentation=man:siteRegistrar(1)

[Service]
ExecStart={execPath} -v 1 --callTrackings monitor+ --callTrackings invoke+  --svcName="svcSiteRegistrars"  -i csPerformer
Restart=always
RestartSec=60

[Install]
WantedBy=default.target
"""
    return templateStr


systemdSeed.setup(
    seedType="sysdSysUnit",  # or sysdUserUnit
    sysdUnitName="siteRegistrars",
    sysdUnitFileFunc=sysdUnitFileFunc,
)

# systemdSeed.plantWithWhich("seedSystemd.cs")
