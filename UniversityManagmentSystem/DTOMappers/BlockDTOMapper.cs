using UniversityManagmentSystem.DTOs.RequestDTO;
using UniversityManagmentSystem.DTOs.ResponseDTO;
using UniversityManagmentSystem.Model;

namespace UniversityManagmentSystem.DTOMappers
{
    public class BlockDTOMapper
    {
        public static Block BlockDTOToEntityMapper(BlockRequestDTO blockRequestDTO)
        {
            Block block = new Block();
            block.Name = blockRequestDTO.Name;
            block.Description = blockRequestDTO.Description;
            block.EstablishedIn = blockRequestDTO.EstablishedIn;
            block.Code = blockRequestDTO.Code;
            return block;
        }

        public static Block BlockEntityToDTOMapper(Block block, BlockRequestDTO blockRequestDTO)
        {
            block.Id = blockRequestDTO.Id;
            block.Name = blockRequestDTO.Name;
            block.Description = blockRequestDTO.Description;
            block.EstablishedIn = blockRequestDTO.EstablishedIn;
            block.Code = blockRequestDTO.Code;
            return block;
        }

        public static BlockResponseDTO EntityToBlockDTO(Block block)
        {
            BlockResponseDTO blockResponseDTO = new BlockResponseDTO();
            blockResponseDTO.Id = block.Id;
            blockResponseDTO.Name = block.Name;
            blockResponseDTO.Description = block.Description;
            blockResponseDTO.EstablishedIn = block.EstablishedIn;
            blockResponseDTO.Code = block.Code;
            blockResponseDTO.CreatedAt = block.CreatedAt;
            blockResponseDTO.UpdatedAt = block.UpdatedAt;
            blockResponseDTO.GlobalId = block.GlobalId;
            return blockResponseDTO;
        }

        public static List<BlockResponseDTO> BlockEntityToDTOMapper(List<Block> blocks)
        {
            List<BlockResponseDTO> blockResponseDTOs = new List<BlockResponseDTO>();
            foreach (Block blockItem in blocks)
            {
                BlockResponseDTO dto = EntityToBlockDTO(blockItem);
                blockResponseDTOs.Add(dto);
            }
            return blockResponseDTOs;
        }
    }
}
