#ifndef BSAINVALIDATION_H
#define BSAINVALIDATION_H


#include <iprofile.h>
#include <QString>

class BSAInvalidation
{
public:

  virtual ~BSAInvalidation() {}

  virtual bool isInvalidationBSA(const QString &bsaName) = 0;

  virtual void deactivate(MOBase::IProfile *profile) = 0;

  virtual void activate(MOBase::IProfile *profile) = 0;

};

#endif // BSAINVALIDATION_H
