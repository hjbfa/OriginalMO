#ifndef BSAEXTRACTOR_GLOBAL_H
#define BSAEXTRACTOR_GLOBAL_H

#include <QtCore/qglobal.h>

#if defined(BSAEXTRACTOR_LIBRARY)
#  define BSAEXTRACTORSHARED_EXPORT Q_DECL_EXPORT
#else
#  define BSAEXTRACTORSHARED_EXPORT Q_DECL_IMPORT
#endif

#endif // BSAEXTRACTOR_GLOBAL_H
