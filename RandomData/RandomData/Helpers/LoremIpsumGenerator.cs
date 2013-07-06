using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomData.Helpers
{
    class LoremIpsumGenerator
    {
        private static string LoremIpsum = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vitae egestas lorem. Donec tempor luctus est ut fringilla. Vivamus adipiscing fermentum felis ut venenatis. Sed nisl nunc, imperdiet quis suscipit sed, rhoncus eget risus. Suspendisse mattis at lacus sed euismod. Curabitur vehicula vulputate odio quis semper. Morbi sed libero sollicitudin, sagittis augue vitae, vestibulum magna.

Maecenas interdum neque quis est adipiscing laoreet. Curabitur orci nibh, viverra nec volutpat tincidunt, convallis in augue. Nam euismod erat nec ullamcorper fringilla. Duis congue posuere magna, volutpat malesuada purus mollis nec. Suspendisse eu pretium ligula. Nullam tincidunt nibh dapibus arcu vehicula, placerat rhoncus massa sodales. Sed placerat pellentesque sem, ut ullamcorper mauris. Sed sit amet lectus purus. Proin dolor velit, tristique non tincidunt sit amet, sollicitudin in tortor. Cras faucibus urna sed erat ornare cursus. Nullam at posuere ligula. Sed id leo pretium, iaculis purus id, dapibus augue. Curabitur sapien ante, ullamcorper eget tortor nec, malesuada lacinia metus. Aenean hendrerit libero quis accumsan volutpat. Donec bibendum gravida nibh in varius. Fusce a lacinia eros, quis varius magna.

Nulla non nibh lacinia, porta tellus vel, tincidunt metus. Morbi ut tristique sem, sed dictum odio. Praesent fringilla ullamcorper odio, at iaculis mi interdum quis. Praesent volutpat aliquam fermentum. Duis rutrum urna vitae interdum tristique. Nulla a dapibus dui. Nullam id lobortis dui, elementum vestibulum nulla. Suspendisse rutrum nunc elit, nec eleifend ante vestibulum at. In hac habitasse platea dictumst. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Morbi et ante ultrices, egestas tellus sed, adipiscing risus. Nulla sed placerat dolor. Donec sit amet risus nec lectus consectetur varius. Donec non lobortis orci. Donec vulputate, lectus sit amet iaculis dapibus, orci leo suscipit massa, sed ornare mauris neque in odio. Praesent consequat augue vel auctor dignissim.

Nunc posuere, sapien vel ultricies commodo, tortor ante dignissim sapien, vel dignissim metus turpis a velit. Aenean ut ligula et lorem ornare semper vitae et est. Phasellus et purus massa. Praesent varius pellentesque quam, eu dignissim augue commodo in. Duis ut diam facilisis, placerat magna quis, malesuada nunc. Ut et hendrerit nunc. Maecenas non interdum lectus, eget bibendum neque. Praesent sagittis augue eget ligula pharetra euismod. Donec venenatis sem ac neque tristique, eu volutpat eros facilisis. Morbi eget hendrerit felis. Sed scelerisque erat est, bibendum bibendum arcu mattis vel.

Vestibulum quis dui ligula. Pellentesque eu diam turpis. Nam bibendum et dui nec pellentesque. Fusce faucibus ultricies elit, aliquet sodales orci placerat in. Mauris nec volutpat arcu. Sed a arcu est. Nullam eu sagittis arcu. Quisque elementum erat non massa adipiscing aliquam. Sed at magna convallis arcu mollis imperdiet nec ut erat.

Sed lobortis ultricies lacinia. Quisque ut felis ut quam gravida mollis ac nec lorem. Cras eget tellus posuere, accumsan mi in, varius est. Vivamus non lectus lacus. Mauris viverra rutrum sem id scelerisque. Sed congue, purus eget auctor rhoncus, tortor quam luctus risus, at rutrum neque neque in diam. Curabitur vel faucibus erat, a lobortis nulla. Duis lobortis orci vitae tellus pellentesque tristique. Integer mollis justo vitae venenatis viverra. Quisque egestas velit ante, ut ultrices dui aliquam sed. Sed cursus, odio eu scelerisque congue, felis diam dignissim erat, ac condimentum enim eros vel lectus. Duis nec risus massa. Praesent nec arcu tristique, egestas diam in, tincidunt ipsum.

Etiam ultrices, urna at iaculis lobortis, dolor erat tincidunt justo, nec aliquam leo erat quis tellus. Fusce luctus felis nulla, vel bibendum nisl convallis sodales. Quisque eu tempor lacus, ut sodales diam. Curabitur eget enim ipsum. Morbi pulvinar ligula nec augue cursus malesuada vel nec erat. Nulla nisi nunc, fermentum eget massa sit amet, ullamcorper varius metus. Cras ac leo auctor, tincidunt erat nec, scelerisque augue. Curabitur venenatis non purus sit amet tristique. Nam massa magna, lacinia nec velit nec, dignissim venenatis nulla. Ut pellentesque molestie urna.

Nulla sed tellus metus. Nam in justo et arcu iaculis porttitor. Sed et dapibus nulla, non vestibulum purus. Fusce vestibulum tincidunt sem interdum eleifend. Nunc enim sapien, pulvinar eget ultrices sed, varius non arcu. Phasellus id fringilla urna, id volutpat erat. Etiam lobortis dolor nec turpis commodo, non lacinia arcu viverra. Pellentesque mattis aliquam fermentum. Nulla placerat est in ultrices placerat. Integer laoreet dignissim erat quis dictum.";

        public string GetLoremIpsum(int length)
        {
            return LoremIpsum.Substring(0, length);
        }
    }
}
